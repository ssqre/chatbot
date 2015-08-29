/*
 * Author  : Copyright (c) Calinyara
 * E-mail  : calinyara@gmail.com
 * 
 * ChatBot
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conversive.Verbot5;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace ChatBot
{
    public partial class ChatBotForm : Form
    {
        Verbot5Engine verbot;
        State state;
        string stCKBFileFilter = "KnowledgeBase file (*.ckb)|*.ckb";
        string stFormName = "ChatBot";

        SpeechSynthesizer speaker;      // define speech synthesis engine
        SpeechRecognitionEngine recognizer;    // define speech recognition engine


        public ChatBotForm()
        {
            InitializeComponent();

            this.verbot = new Verbot5Engine();
            this.state = new State();
            this.speaker =  new SpeechSynthesizer();
            this.recognizer = new SpeechRecognitionEngine();
            this.openFileDialog1.Filter = this.stCKBFileFilter;
            this.Text = this.stFormName;

        }

        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                this.getReply(this.txtSend.Text.Trim());
            }
        }


        private string getReply(string str)
        {
            string stInput = str;
            this.txtSend.Text = "";
            Reply reply = this.verbot.GetReply(stInput, this.state);
            if (reply != null)
            {
                this.txtReply.Text = "You: " + str + "\r\n" + "julia:" + reply.Text;
                this.parseEmbeddedOutputCommands(reply.AgentText);
                this.runProgram(reply.Cmd);
                return reply.Text;
            }
            else
            {
                this.txtReply.Text = "You: " + str + "\r\n" + "julia: pardon?!";
                return "pardon?!";
            }
        }


        private void btnGetReply_Click(object sender, EventArgs e)
        {
            this.getReply(this.txtSend.Text.Trim());
        }


        private void loadMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.RestoreDirectory = true;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.verbot.AddCompiledKnowledgeBase(this.openFileDialog1.FileName);
                this.state.CurrentKBs.Clear();
                this.state.CurrentKBs.Add(this.openFileDialog1.FileName);
            }
        }


        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void parseEmbeddedOutputCommands(string text)
        {
            string startCommand = "<";
            string endCommand = ">";

            int start = text.IndexOf(startCommand);
            int end = -1;

            while (start != -1)
            {
                end = text.IndexOf(endCommand, start);
                if (end != -1)
                {
                    string command = text.Substring(start + 1, end - start - 1).Trim();
                    if (command != "")
                    {
                        this.runEmbeddedOutputCommand(command);
                    }
                }
                start = text.IndexOf(startCommand, start + 1);
            }
        }//parseEmbeddedOutputCommands(string text)

        private void runEmbeddedOutputCommand(string command)
        {
            int spaceIndex = command.IndexOf(" ");

            string function;
            string args;
            if (spaceIndex == -1)
            {
                function = command.ToLower();
                args = "";
            }
            else
            {
                function = command.Substring(0, spaceIndex).ToLower();
                args = command.Substring(spaceIndex + 1);
            }

            try
            {
                switch (function)
                {
                    case "quit":
                    case "exit":

                        this.Close();
                        break;
                    case "run":
                        this.runProgram(args);
                        break;
                    default:
                        break;
                }//switch
            }
            catch { }
        }//runOutputEmbeddedCommand(string command)

        private void runProgram(string command)
        {
            try
            {
                string[] pieces = this.splitOnFirstUnquotedSpace(command);

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = pieces[0].Trim();
                proc.StartInfo.Arguments = pieces[1];
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }
            catch { }
        }//runProgram(string filename, string args)

        public string[] splitOnFirstUnquotedSpace(string text)
        {
            string[] pieces = new string[2];
            int index = -1;
            bool isQuoted = false;
            //find the first unquoted space
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '"')
                    isQuoted = !isQuoted;
                else if (text[i] == ' ' && !isQuoted)
                {
                    index = i;
                    break;
                }
            }

            //break up the string
            if (index != -1)
            {
                pieces[0] = text.Substring(0, index);
                pieces[1] = text.Substring(index + 1);
            }
            else
            {
                pieces[0] = text;
                pieces[1] = "";
            }

            return pieces;
        }//splitOnFirstUnquotedSpace(string text)


        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, this.stFormName + "\r\nAuthor: Calinyara\r\n" + "Version: " +
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButtonSpeech_CheckedChanged(object sender, EventArgs e)
        {
            btnSpeech.Enabled = true;
        }

        private void InitializeSpeechEngine()
        {
            recognizer.SetInputToDefaultAudioDevice();
            Grammar G  = new DictationGrammar();
            recognizer.LoadGrammar(G);
            G.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(G_SpeechRecognized);
        }


        private void InitializeKnowledgeBase()
        {
            this.verbot.AddCompiledKnowledgeBase(Application.StartupPath + @"\julia.ckb");
            this.state.CurrentKBs.Clear();
            this.state.CurrentKBs.Add(Application.StartupPath + @"\julia.ckb");
        }

        void G_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string str = this.getReply(e.Result.Text.Trim());
            //recognizer.RecognizeAsyncCancel(); 
            speaker.Speak(str);
            //recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void radioButtonHand_CheckedChanged(object sender, EventArgs e)
        {
            btnSpeech.Enabled = false;
            btnSpeech.Text = "start";
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            if (radioButtonSpeech.Enabled==true)
            {
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                btnSpeech.Text = "Stop";
                radioButtonSpeech.Enabled = false;
                radioButtonHand.Enabled = false;
            } 
            else
            {
                recognizer.RecognizeAsyncCancel();
                btnSpeech.Text = "Start";
                radioButtonHand.Enabled = true;
                radioButtonSpeech.Enabled = true;
            }
        }

        private void ChatBotForm_Load(object sender, EventArgs e)
        {
            InitializeKnowledgeBase();
            InitializeSpeechEngine();
        }

    }
}

