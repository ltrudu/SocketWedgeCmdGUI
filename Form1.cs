using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SocketWedgeCmdGUI
{
    public partial class Form1 : Form
    {
        private String mCmdContent = "";
        private SocketWedgeConfig mConfig;

        private System.Windows.Forms.TextBox editBox1;
        private System.Windows.Forms.TextBox editBox2;

        public Form1()
        {
            InitializeComponent();
            lvServers.View = View.Details;
            lvServers.MouseDoubleClick += LvServers_MouseDoubleClick;
            // Initialize the TextBoxes for editing
            editBox1 = new System.Windows.Forms.TextBox { Visible = false };
            editBox2 = new System.Windows.Forms.TextBox { Visible = false };

            editBox1.Leave += EditBox1_Leave;
            editBox2.Leave += EditBox2_Leave;

            editBox1.KeyPress += EditBox_KeyPress;
            editBox2.KeyPress += EditBox_KeyPress;

            Controls.Add(editBox1);
            Controls.Add(editBox2);
        }

        private void LvServers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvServers.SelectedItems.Count > 0)
            {
                ListViewItem item = lvServers.SelectedItems[0];
                Rectangle rect1 = item.SubItems[0].Bounds;
                Rectangle rect2 = item.SubItems[1].Bounds;

                // Adjust the position and size of the TextBoxes
                editBox1.SetBounds(rect1.X + lvServers.Left, rect1.Y + lvServers.Top, rect1.Width, rect1.Height);
                editBox2.SetBounds(rect2.X + lvServers.Left, rect2.Y + lvServers.Top, rect2.Width, rect2.Height);

                editBox1.Text = item.SubItems[0].Text;
                editBox2.Text = item.SubItems[1].Text;

                editBox1.Visible = true;
                editBox2.Visible = true;

                editBox1.BringToFront();
                editBox2.BringToFront();

                editBox1.Focus();
            }
        }

        private void EditBox1_Leave(object sender, EventArgs e)
        {
            if (lvServers.SelectedItems.Count > 0)
            {
                ListViewItem item = lvServers.SelectedItems[0];
                item.SubItems[0].Text = editBox1.Text;
            }
            editBox1.Visible = false;
        }

        private void EditBox2_Leave(object sender, EventArgs e)
        {
            if (lvServers.SelectedItems.Count > 0)
            {
                ListViewItem item = lvServers.SelectedItems[0];
                item.SubItems[1].Text = editBox2.Text;
            }
            editBox2.Visible = false;
        }

        private void EditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ((System.Windows.Forms.TextBox)sender).Visible = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Command Files (*.cmd)|*.cmd",
                Title = "Select a CMD File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    // Open the file using a StreamReader
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read the entire file content into a string
                        string fileContent = reader.ReadToEnd();
                        Console.WriteLine("File content:");
                        Console.WriteLine(fileContent);
                        mConfig = getConfigFromArguments(fileContent);
                        updateGUI();
                        Console.WriteLine(mConfig.ToString());
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred while reading the file:");
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs eventArgs)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Command Files (*.cmd)|*.cmd",
                Title = "Save a CMD File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Console.WriteLine("File will be saved to: " + filePath);

                updateConfigFromGUI();

                String configAsString = mConfig.getCMDFileString();
                System.IO.File.WriteAllText(filePath, configAsString);
            }
        }

        private void updateConfigFromGUI()
        {
            mConfig = new SocketWedgeConfig();
            mConfig.mCommandWindowTitle = txtCmdTitle.Text;
            if (mConfig.mCommandWindowTitle.Length == 0)
                mConfig.mCommandWindowTitle = "SocketWedge Test";

            mConfig.mWindowName = txtWindowName.Text;
            if (mConfig.mWindowName.Length == 0) mConfig.mWindowName = "Notepad";

            mConfig.mWedge = cbWedge.Checked;
            mConfig.mAddReturn = cbAddReturn.Checked;
            foreach (ListViewItem item in lvServers.Items)
            {
                string key = item.SubItems[0].Text;
                string value = item.SubItems[1].Text;
                mConfig.mServerList[key] = value;
            }
            if (mConfig.mServerList.Count == 0)
                mConfig.mServerList["192.168.1.1"] = "25250";
        }


        private SocketWedgeConfig getConfigFromArguments(String arguments)
        {
            SocketWedgeConfig config = new SocketWedgeConfig();

            // Extract title
            Match titleMatch = Regex.Match(arguments, @"title\s+(.*)");

            if (titleMatch.Success)
            {
                // Extract the text after "title"
                config.mCommandWindowTitle = titleMatch.Groups[1].Value;
            }
            else
            {
                config.mCommandWindowTitle = "SocketWedge";
            }

            // Extract IP addresses and ports           
            Regex ipPortRegex = new Regex(@"/Server=([\d\.]+):(\d+)");
            foreach (Match match in ipPortRegex.Matches(arguments))
            {
                string ip = match.Groups[1].Value;
                String port = match.Groups[2].Value;
                config.mServerList[ip] = port;
            }

            // Extract boolean values
            config.mAddReturn = Regex.IsMatch(arguments, @"/AddReturn=1");
            config.mWedge = Regex.IsMatch(arguments, @"/Wedge=1");

            // Extract string value
            config.mWindowName = Regex.Match(arguments, @"/FocusWindow=([^\s]+)").Groups[1].Value;

            return config;
        }

        private void updateGUI()
        {
            txtCmdTitle.Text = mConfig.mCommandWindowTitle;
            txtWindowName.Text = mConfig.mWindowName;
            cbAddReturn.Checked = mConfig.mAddReturn;
            cbWedge.Checked = mConfig.mWedge;
            lvServers.Items.Clear();
            foreach(KeyValuePair<String, String> servers in mConfig.mServerList)
            {
                ListViewItem item = new ListViewItem(servers.Key);
                item.SubItems.Add(servers.Value);
                lvServers.Items.Add(item);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvServers.SelectedItems.Count > 0)
            {
                lvServers.Items.Remove(lvServers.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("IP");
            item.SubItems.Add("PORT");
            lvServers.Items.Add(item);

        }
    }
}
