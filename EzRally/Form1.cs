using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzRally
{
    public partial class Form1 : Form
    {
        ConfigFiles configurationFiles;
        List<Developer> sprintTeam;
        List<SprintStory> currentSprintStories;
        List<StoryTasks> storyTaskBreakup;
        List<TaskAllocation> finalAllocation;

        public Form1()
        {
            InitializeComponent();
        }

        #region "Data Load Operations"

        private string LoadStories()
        {
            string loadMessage = string.Empty;
            currentSprintStories = new List<SprintStory>();
            FileManager fm = new FileManager();
            try
            {
                using (StreamReader reader = fm.ReadFile(configurationFiles.StoryConfigFile))
                {
                    while (!reader.EndOfStream)
                    {
                        var values = reader.ReadLine().Split(',');
                        SprintStory newStory = new SprintStory();
                        newStory.StoryTitle = values[0];
                        newStory.StoryID = values[1];
                        newStory.Points = Convert.ToInt32(values[2]);
                        currentSprintStories.Add(newStory);
                    }
                    Console.WriteLine(currentSprintStories.ToString());
                }
            }
            catch (Exception ex)
            {
                loadMessage = String.Format(Constants.CONFIG_LOAD_EXCEPTION, configurationFiles.TaskConfigFile);
                throw;
            }
            return loadMessage;
        }

        //private string LoadStoryPointMapping()
        //{
        //    string loadMessage = string.Empty;
        //    pointsMapping = new List<StoryPoints>();
        //    try
        //    {
        //        FileManager fm = new FileManager();
        //        using (StreamReader reader = fm.ReadFile(configurationFiles.StoryPointConfigFile))
        //        {
        //            while (!reader.EndOfStream)
        //            {
        //                var line = reader.ReadLine();
        //                var values = line.Split(',');
        //                StoryPoints spMapping = new StoryPoints();
        //                spMapping.PointScore = Convert.ToInt32(values[0]);
        //                spMapping.Hours = Convert.ToInt32(values[1]);
        //                pointsMapping.Add(spMapping);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        loadMessage = String.Format(Constants.CONFIG_LOAD_EXCEPTION, configurationFiles.TaskConfigFile);
        //    }
        //    return loadMessage;
        //}
        private string LoadStoryTasks()
        {
            string loadMessage = string.Empty;
            int taskAllocation = 0;
            storyTaskBreakup = new List<StoryTasks>();
            try
            {
                FileManager fm = new FileManager();
                using (StreamReader reader = fm.ReadFile(configurationFiles.TaskConfigFile))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        StoryTasks task = new StoryTasks();
                        task.TaskName = values[0];
                        task.Percentage = Convert.ToInt32(values[1]);
                        taskAllocation += task.Percentage;
                        switch (Convert.ToInt32(values[2]))
                        {
                            case 1:
                                task.OnshoreOnly = true;
                                break;
                            case 3:
                                task.QAOnly = true;
                                break;
                        }
                        
                        if (Convert.ToInt32(values[3])==1)
                        {
                            task.LeadsOnly = true;
                        }
                        storyTaskBreakup.Add(task);
                    }
                }
                if (taskAllocation != 100)
                {
                    loadMessage = Constants.TASK_CONFIG_NOT_HUNDRED;
                }
            }
            catch (Exception ex)
            {
                loadMessage = String.Format(Constants.CONFIG_LOAD_EXCEPTION, configurationFiles.TaskConfigFile);
            }
            return loadMessage;
        }

        private string LoadDevelopers()
        {
            string loadMessage = string.Empty;

            sprintTeam = new List<Developer>();
            try
            {
                FileManager fm = new FileManager();
                using (StreamReader reader = fm.ReadFile(configurationFiles.TeamConfigFile))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        Developer newTeamMember = new Developer();
                        newTeamMember.Name = values[0];
                        newTeamMember.Email = values[1];
                        if (values[2] == "1")
                        {
                            newTeamMember.IsLead = true;
                        }
                        if (values[3] == "1")
                        {
                            newTeamMember.IsOnshore = true;
                        }
                        if (values[4] == "1")
                        {
                            newTeamMember.IsQA = true;
                        }
                        newTeamMember.Capacity = Convert.ToInt32(values[5]);
                        sprintTeam.Add(newTeamMember);
                    }
                }
            }
            catch (Exception ex)
            {
                loadMessage = String.Format(Constants.CONFIG_LOAD_EXCEPTION, configurationFiles.TaskConfigFile);
            }

            return loadMessage;
        }

        #endregion

        #region "Data Processing"

        private bool LoadSprintData()
        {
            bool dataLoadStatus = true;
            string returnMessage = string.Empty;

            returnMessage = LoadStoryTasks();
            if (returnMessage != string.Empty)
            {
                dataLoadStatus = false;
                MessageBox.Show(returnMessage, Constants.APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return dataLoadStatus;
            }

            returnMessage = LoadDevelopers();
            if (returnMessage != string.Empty)
            {
                dataLoadStatus = false;
                MessageBox.Show(returnMessage, Constants.APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return dataLoadStatus;
            }

            returnMessage = LoadStories();
            if (returnMessage != string.Empty)
            {
                dataLoadStatus = false;
                MessageBox.Show(returnMessage, Constants.APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return dataLoadStatus;
            }

            return dataLoadStatus;
        }

        private void generateCSVData()
        {
            finalAllocation = new List<TaskAllocation>();
            foreach (var story in currentSprintStories)
            {
                //Console.WriteLine("Row -" + (i.ToString()));
                //Display Color	Expedite	Ready	Actuals	Blocked	Blocked Reason	Estimate	State	To Do	Work Product	Name	Description	Notes	Owner
                foreach (var task in storyTaskBreakup)
                {
                    //Console.WriteLine("Task -" + j.ToString());
                    TaskAllocation a = new TaskAllocation();
                    a.Display = "";
                    a.Color = "";
                    a.Expedite = "";
                    a.Ready = "TRUE";
                    a.Actuals = "";
                    a.Blocked = "FALSE";
                    a.State = "Defined";
                    a.Description = "";
                    a.Notes = "";
                    // User Story #
                    a.WorkProduct = story.StoryTitle;
                    // Task Name
                    a.Name = task.TaskName;
                    //StoryPoints p = pointsMapping.Find(x => x.PointScore.Equals(story.Points));
                    // Console.WriteLine(p.Hours);
                    //float taskEffort = Convert.ToInt32(p.Hours) * (Convert.ToInt32(task.Percentage));
                   // a.Estimate = (taskEffort / 100);

                    a.ToDo = a.Estimate;
                    a.Owner = "";

                    finalAllocation.Add(a);
                    // j += 1;
                }
                // j = 0;
                // i += 1;
            }
        }

        #endregion

        #region "Form Load and Button Click Events"

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCreateCSV.Enabled = false;
        }

        private void btnCreateTasks_Click(object sender, EventArgs e)
        {
            if (configurationFiles != null)
            {
                if (configurationFiles.ValidConfiguration == true)
                {
                    if (LoadSprintData()== true)
                    {
                        AllocationManager am = new AllocationManager();
                        finalAllocation = am.GenerateAllocations(currentSprintStories, storyTaskBreakup, sprintTeam, Convert.ToInt32(nudStoryHours.Value));
                        dgvTaskAllocation.DataSource = finalAllocation;
                    }

                }
                else
                {
                    
                    MessageBox.Show(Constants.CONFIG_FILES_NOT_SETUP_2, Constants.APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(Constants.CONFIG_FILES_NOT_SETUP, Constants.APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnSaveFilePaths_Click(object sender, EventArgs e)
        {
            configurationFiles = new ConfigFiles();
            configurationFiles.ValidConfiguration = true;
            configurationFiles.TeamConfigFile = txtTeamConfigPath.Text;
            configurationFiles.OutputFile = txtOutputPath.Text;
            configurationFiles.StoryConfigFile = txtStoryConfigPath.Text;
            //configurationFiles.StoryPointConfigFile = txtStoryPointConfigPath.Text;
            configurationFiles.TaskConfigFile = txtTaskConfigPath.Text;


            foreach (PropertyInfo prop in configurationFiles.GetType().GetProperties())
            {
                if (prop.Name != "ValidConfiguration")
                { 
                    string file = prop.GetValue(configurationFiles).ToString();

                    if (file == string.Empty)
                    {
                        configurationFiles.ValidConfiguration = false;
                        MessageBox.Show(Constants.CONFIG_FILE_NOT_SELECTED, Constants.APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    else if (!File.Exists(file))
                    {
                        configurationFiles.ValidConfiguration = false;
                        MessageBox.Show(String.Format(Constants.CONFIG_FILE_MISSING, file), Constants.APPTITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                }
            }
        }

        private void btnCreateCSV_Click(object sender, EventArgs e)
        {

        }

        #region "File Path Configuration"

        private void btnSetTeamConfigPath_Click(object sender, EventArgs e)
        {
            if (ofdSelectFile.ShowDialog() == DialogResult.OK)
            {
                txtTeamConfigPath.Text = ofdSelectFile.FileName;
            }
        }

        private void btnSetTaskPath_Click(object sender, EventArgs e)
        {
            if (ofdSelectFile.ShowDialog() == DialogResult.OK)
            {
                txtTaskConfigPath.Text = ofdSelectFile.FileName;
            }
        }

        private void btnSetStoryPath_Click(object sender, EventArgs e)
        {
            if (ofdSelectFile.ShowDialog() == DialogResult.OK)
            {
                txtStoryConfigPath.Text = ofdSelectFile.FileName;
            }
        }

        private void btnSetOutputPath_Click(object sender, EventArgs e)
        {
            if (sfdSaveFile.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = ofdSelectFile.FileName;
            }
        }

        #endregion

        #endregion
        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveOfflineData();
        }

        private void SaveOfflineData()
        {
            if (configurationFiles != null)
            {

            }
        }

        private void LoadOfflineData()
        {

        }
    }
}
