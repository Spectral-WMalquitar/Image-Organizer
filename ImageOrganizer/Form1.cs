using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ImageOrganizer
{
    public partial class Form1 : Form
    {
        MySqlConnection Connection;
        public Form1()
        {

            InitializeComponent();
            string connString = "SERVER = localhost;PORT = 3306; DATABASE = imageorganizer ; UID = root; PWD = ryan";
            Connection = new MySqlConnection(connString);
            Connection.Open();
        }
        DirectoryInfo directInfo;//main folder
        DirectoryInfo[] folders;//collection of folder
        FileInfo[] files;//collection og files in slected folder
        FileInfo[] filesinalbum;
        bool actionSetter = false, commandSetter = false;
        DirectoryInfo DestinationPath;
        bool Rename = true;
        string Command = "";
        public void PropagatePic()//view all images in selested folder
        {
            listBox2.Items.Clear();
            panel1.Controls.Clear();
            files = new FileInfo[10000];
            int x = 20, y = 20;
            int maxHeight = -1;
            int counter = 0;
            Image image;
            FileStream mySteam;
            foreach (FileInfo file in folders[listBox1.SelectedIndex].GetFiles())//get all files in folder
            {
                if (file.Extension == ".png" || file.Extension == ".jpeg" || file.Extension == ".jpg")//only select files with this extensions
                {
                    listBox2.Items.Add(file.Name);//add found file in listboximage
                    mySteam = new FileStream(file.FullName, FileMode.Open);//add image in panel, able to move,copy,delete files
                    image = Image.FromStream(mySteam);
                    PictureBox pic = new PictureBox();
                    pic.Image = image;
                    mySteam.Dispose();
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    x += pic.Width + 10;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if (x > this.ClientSize.Width - 350)
                    {
                        x = 20;
                        y += maxHeight + 10;
                    }
                    this.panel1.Controls.Add(pic);
                    files[counter] = file;//add files in array of files of the selected folder
                    counter++;
                }

            }

        }

        public void BigPic()//view selected image in bigger size
        {
            FileInfo imageFiles = files[listBox2.SelectedIndex];
            panel1.Controls.Clear();
            Image image;
            FileStream mySteam;
            int x = 20, y = 20;
            int maxHeight = -1;
            mySteam = new FileStream(imageFiles.FullName, FileMode.Open);
            image = Image.FromStream(mySteam);
            PictureBox pic = new PictureBox();
            pic.Image = image;
            mySteam.Dispose();
            pic.Location = new Point(x, y);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Height = 400;
            pic.Width = 400;
            x += pic.Width + 10;
            maxHeight = Math.Max(pic.Height, maxHeight);
            if (x > this.ClientSize.Width - 100)
            {
                x = 20;
                y += maxHeight + 10;
            }
            this.panel1.Controls.Add(pic);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BigPic();
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                menuStripMuliSelect.Visible = true;
                menuStripAction.Visible = true;
                actionSetter = false;
                btnMoveOrCopy.Enabled = false;
                directInfo = new DirectoryInfo(FBD.SelectedPath);
                string path = FBD.SelectedPath.Replace("\\","\\\\");
                string query = "UPDATE tblstartup SET StartUpPath = '" + path + "' WHERE StartUpID = '1'";
                MySqlCommand commandAdd = new MySqlCommand(query, Connection);
                commandAdd.ExecuteNonQuery();
                if (Directory.Exists(Path.GetDirectoryName(FBD.SelectedPath)))
                {
                    RefreshFolder();
                }

            }
        }

        private void RefreshFolder()//Refresh the folder names in listboxfolder
        {
            folders = new DirectoryInfo[10000];
            panel1.Controls.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            folders[0] = directInfo;
            int folderCounter = 1;
            
            foreach (DirectoryInfo diInfo in directInfo.GetDirectories())//save folder and subfolders in array
            {
                folders[folderCounter] = diInfo;
                folderCounter++;
            }

            if (folders.Length > 0)
            {
                Boolean parentFolder = true;
                foreach (DirectoryInfo folder in folders)
                {
                    if (folder != null)
                    {
                        if (parentFolder)
                        {
                            listBox1.Items.Add(folder.Name.ToString() + " (Main Folder)");
                            parentFolder = false;
                        }
                        else
                            listBox1.Items.Add(folder.Name);
                    }
                }
            }
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {

                menuStripMultiSelectOn.CheckState = CheckState.Checked;
                listBox2.SelectionMode = SelectionMode.MultiExtended;
                menuStripMultiSelectOff.CheckState = CheckState.Unchecked;
                PropagatePic();


        }

        private void menuStripAction_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndices.Count == 0)
            {
                menuStripCopy.Enabled = false;
                menuStripDelete.Enabled = false;
                menuStripMove.Enabled = false;
                menuStripRenameImage.Enabled = false;
            }
            else
            {
                menuStripCopy.Enabled = true;
                menuStripDelete.Enabled = true;
                menuStripMove.Enabled = true;
                if (menuStripMultiSelectOn.CheckState == CheckState.Checked)
                    menuStripRenameImage.Enabled = false;
                else
                    menuStripRenameImage.Enabled = true;
            }

            if (txtCurrentFolder.Text.Length > 0)
                MenuStripRenameFolder.Enabled = true;
            else
                MenuStripRenameFolder.Enabled = false;

            
        }

        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            BigPic();
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStripMultiSelectOn.CheckState = CheckState.Unchecked;
            menuStripMultiSelectOff.CheckState = CheckState.Checked;
            listBox2.SelectionMode = SelectionMode.One;
            PropagatePic();
        }

        private void menuStripDelete_Click(object sender, EventArgs e)
        {
            Command = "Delete";
            RenameVisible(false);
           // string[] FilesToDelete = new string[listBox2.SelectedIndices.Count];
            if (MessageBox.Show("Delete All Selected Image?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (int Delete in listBox2.SelectedIndices)
                { File.Delete(files[Delete].FullName);
                 }
                PropagatePic();
                MessageBox.Show("Image(s) Deleted!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void menuStripMove_Click(object sender, EventArgs e)
        {
            Command = "Move";
            RenameVisible(false); 
            MoveCopyVisible(true);
            btnMoveOrCopy.Text = "Move";
            MessageBox.Show("Select the folder where you want to move the selected images","Notice!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void MoveCopyVisible(bool YesOrNo)
        {
            if (YesOrNo == true)
            {
                lblFolderDestination.Visible = true;
                txtFolderDestination.Visible = true;
                btnMoveOrCopy.Visible = true;
                btnCancel.Visible = true;
                actionSetter = true;
                btnPath.Visible = true;
            }
            else
            {
                lblFolderDestination.Visible = false;
                txtFolderDestination.Visible = false;
                txtFolderDestination.Text = "";
                btnMoveOrCopy.Visible = false;
                btnMoveOrCopy.Enabled = false;
                btnCancel.Visible = false;
                btnPath.Visible = false;
                actionSetter = false;
            }
        }

        private void btnMoveOrCopy_Click(object sender, EventArgs e)
        {
            //string[] FilesToMoveOrCopy = new string[listBox2.SelectedIndices.Count];
            if (btnMoveOrCopy.Text == "Move")
            {      
                if (MessageBox.Show("Move All Selected Image?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (int Move in listBox2.SelectedIndices)
                    {
                        if (File.Exists(DestinationPath.FullName + @"\" + files[Move].Name))
                            MessageBox.Show(files[Move].Name + " already exist in " + DestinationPath, "This file cannot be moved", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            File.Move(files[Move].FullName, DestinationPath.FullName + @"\" + files[Move].Name);
                         }  
                    }
                    PropagatePic(); 
                    MessageBox.Show("Image(s) Moved!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MoveCopyVisible(false);
                }
            }
            else if (btnMoveOrCopy.Text == "Copy")
            {

                if (MessageBox.Show("Copy All Selected Image?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (int Copy in listBox2.SelectedIndices)
                    {
                        if (File.Exists(DestinationPath.FullName + @"\" + files[Copy].Name))
                            MessageBox.Show(files[Copy].Name + " already exist in " + DestinationPath, "This file cannot be copied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            File.Copy(files[Copy].FullName, DestinationPath.FullName + @"\" + files[Copy].Name);
                         }
                    }
                    PropagatePic();
                    MessageBox.Show("Image(s) Copied!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MoveCopyVisible(false);
                }
            }
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actionSetter == true)
            {
                txtFolderDestination.Text = listBox1.SelectedItem.ToString();
                DestinationPath = folders[listBox1.SelectedIndex];
                btnMoveOrCopy.Enabled = true;

            }
            else
            {
                txtCurrentFolder.Text = listBox1.SelectedItem.ToString();
                PropagatePic();
            }
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MoveCopyVisible(false);
            RenameVisible(false);
            btnAddAlbum.Visible = false;
        }

        private void menuStripCopy_Click(object sender, EventArgs e)
        {
            Command = "Copy";
            RenameVisible(false);
            MoveCopyVisible(true);
            btnMoveOrCopy.Text = "Copy";
            MessageBox.Show("Select the folder where you want to copy the selected images", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
        }

        private void renameFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Command = "Rename";
            RenameVisible(true);
            MoveCopyVisible(false);
            Rename = true;
 
        }

        public void RenameVisible(Boolean x)
        {
            if (x)
            {
                txtRename.Visible = true;
                btnRename.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                btnCancel.Visible = false;
                txtRename.Visible = false;
                btnRename.Visible = false;
                btnRename.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                txtFolderDestination.Text = FBD.SelectedPath;
                DestinationPath = new DirectoryInfo(FBD.SelectedPath);
                btnMoveOrCopy.Enabled = true;

            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            bool ok=true;
            if (Rename)
            {
                DirectoryInfo renameFolder = folders[listBox1.SelectedIndex];
                string folderToRename = renameFolder.FullName.ToString();
                string folderName = renameFolder.Name.ToString();
                string newFolderName = folderToRename.Replace(folderName, txtRename.Text);
                foreach(DirectoryInfo diInfo in folders)
                {
                    if (diInfo!=null&&diInfo.Name.ToLower() == txtRename.Text.ToLower())
                        ok = false;

                }
                if (ok)
                {

                    try
                    {
                        Directory.Move(folderToRename, newFolderName);
                        listBox1.Items.Clear();
                        RefreshFolder();
                         RenameVisible(false);

                        MessageBox.Show("Rename succesfull!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Name already exist!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                FileInfo renameImage = files[listBox2.SelectedIndex];
                string imageToRename = renameImage.FullName;
                string imageName = renameImage.Name;
                string imageExtension = renameImage.Extension;
                string newImageName = imageToRename.Replace(imageName, txtRename.Text + imageExtension);
                foreach (FileInfo file in files)
                {
                    if (file!=null && file.Name.ToLower() == txtRename.Text.ToLower() + imageExtension)
                        ok = false;
                }
                if (ok)
                {
                    try
                    {
                        File.Move(imageToRename, newImageName);
                        listBox1.Items.Clear();
                        listBox2.Items.Clear();
                        RefreshFolder();
                         RenameVisible(false);
                        MessageBox.Show("Rename succesfull!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Name already exist!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void txtRename_TextChanged(object sender, EventArgs e)
        {
            if (txtRename.Text.Length > 0)
            {
                btnRename.Enabled = true;
                btnAddAlbum.Enabled = true;
            }
            else
            {
                btnAddAlbum.Enabled = false;
                btnRename.Enabled = false;
            }
        }

        private void menuStripRenameImage_Click(object sender, EventArgs e)
        {
            Command = "Rename";
            MoveCopyVisible(false);
            RenameVisible(true);
            Rename = false;
        }

        private void KeyRestriction(ref object sender, ref KeyPressEventArgs e)
        {
            
                if (!char.IsControl(e.KeyChar) && (e.KeyChar=='>'|| e.KeyChar=='<'|| e.KeyChar=='\\'|| e.KeyChar=='|'|| e.KeyChar=='*'|| e.KeyChar=='?'|| e.KeyChar==':'|| e.KeyChar=='\"'))
                    e.Handled = true;
           
                  
            }

        private void txtRename_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyRestriction(ref sender, ref e);
        }

        private void createAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddAlbum.Visible = true;
            txtRename.Visible = true;
            btnCancel.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            listBox3.Items.Add(txtRename.Text);
            string query = "INSERT INTO tblalbums(AlbumName) " + " VALUES('" + txtRename.Text + "')";
            MySqlCommand commandAdd = new MySqlCommand(query, Connection);
            commandAdd.ExecuteNonQuery();
            btnAddAlbum.Visible = false;
            btnCancel.Visible = false;
            txtRename.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string path = "";
            string query = "SELECT * FROM tblstartup";
            MySqlCommand command = new MySqlCommand(query, Connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                path= reader[1].ToString(); 
            } reader.Close();
            
            directInfo = new DirectoryInfo(path);
            if (Directory.Exists(Path.GetDirectoryName(path)))
            {
                RefreshFolder();
            }


            string query2 = "SELECT * FROM tblalbums";
            MySqlCommand command2 = new MySqlCommand(query2, Connection);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
            
                listBox3.Items.Add(reader2[1].ToString());
            } reader2.Close();
        }

        private void addToAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex > -1)
            {
                RenameVisible(false);
                int albumIndex = listBox3.SelectedIndex + 1;
                foreach (int pic in listBox2.SelectedIndices)
                {
                    string path = files[pic].FullName.ToString();
                    path = path.Replace("\\", "\\\\");
                    string query = "INSERT INTO tblimage(AlbumsID,ImageName,ImagePath) " + " VALUES('" + albumIndex + "','" + files[pic].Name + "','" + path + "')";
                    MySqlCommand command = new MySqlCommand(query, Connection);
                    command.ExecuteNonQuery();
                }
                PropagatePic();
                MessageBox.Show("Image(s) Added!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { MessageBox.Show("Please select an album", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            filesinalbum = new FileInfo[100000];
                listBox4.Items.Clear();
                panel1.Controls.Clear();
                
                int x = 20, y = 20;
                int maxHeight = -1;
                int counter = 0;
                Image image;
                FileStream mySteam;

                string query = "SELECT * FROM tblimage WHERE AlbumsID = " + (listBox3.SelectedIndex + 1).ToString();
                MySqlCommand command = new MySqlCommand(query, Connection);
                MySqlDataReader reader = command.ExecuteReader();
            
                while (reader.Read())
                {
              
                    
                    FileInfo file = new FileInfo(reader[3].ToString());
                    listBox4.Items.Add(reader[2].ToString());//add found file in listboximage
                    mySteam = new FileStream(reader[3].ToString(), FileMode.Open);//add image in panel, able to move,copy,delete files
                    image = Image.FromStream(mySteam);
                    PictureBox pic = new PictureBox();
                    pic.Image = image;
                    mySteam.Dispose();
                    pic.Location = new Point(x, y);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    x += pic.Width + 10;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if (x > this.ClientSize.Width - 350)
                    {
                        x = 20;
                        y += maxHeight + 10;
                    }
                    this.panel1.Controls.Add(pic);
                    filesinalbum[counter] = file;//add files in array of files of the selected folder
                    counter++;

                } reader.Close();
            
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
             FileInfo imageFiles = filesinalbum[listBox4.SelectedIndex];
            panel1.Controls.Clear();
            Image image;
            FileStream mySteam;
            int x = 20, y = 20;
            int maxHeight = -1;
            mySteam = new FileStream(imageFiles.FullName, FileMode.Open);
            image = Image.FromStream(mySteam);
            PictureBox pic = new PictureBox();
            pic.Image = image;
            mySteam.Dispose();
            pic.Location = new Point(x, y);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Height = 400;
            pic.Width = 400;
            x += pic.Width + 10;
            maxHeight = Math.Max(pic.Height, maxHeight);
            if (x > this.ClientSize.Width - 100)
            {
                x = 20;
                y += maxHeight + 10;
            }
            this.panel1.Controls.Add(pic);
        }
        }
        


    }

