using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TsvMerger
{
    public partial class Form1 : Form
    {
        private string outputPath;
        public Form1()
        {
            InitializeComponent();

            instructions_textbox.Text = "Instructions:" + Environment.NewLine + Environment.NewLine +
                           "- Select TSV or TSV.GZ files using 'Select Files' button." + Environment.NewLine +
                           "- Choose an output location and a name for the output file using the 'Save As' button." + Environment.NewLine +
                           "- Click the 'Merge Files' button to combine the files. A new TSV output file will appear in your chosen directory." + Environment.NewLine +
                           "- Progress bar will update per number of files processed.";

            progress_bar_label.Text = "Progress Bar: ";

            ownership_label.Text = "Created by: Daniel Fewell | Last Updated 11/15/23";
        }

        private void select_files_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            {
                openFileDialog.InitialDirectory = "c:\\"; //Specifies the initial directory to which the openFileDialog opens
                openFileDialog.Filter = "TSV files (*.tsv)|*.tsv|Compressed TSV files (*.tsv.gz)|*.tsv.gz"; //Filter files in directory to display TSV files only
                openFileDialog.FilterIndex = 1; //Filter index is set to the first one in the Filter list (i.e. TSV files)
                openFileDialog.RestoreDirectory = true; //Ensures current working directory is restored to pre-openFileDialogue state
                openFileDialog.Multiselect = true;  //Enables user to select multiple TSV files to load in

                if (openFileDialog.ShowDialog() == DialogResult.OK) //Checks if the user selects OK in the dialog box, indicating that they have chosen which files to load
                {
                    string[] selectedFiles = openFileDialog.FileNames; //Gets the files selected by the user

                    foreach (string file in selectedFiles) //Adds each file name to file_list for user to see which files they selected
                    { 
                        file_list.Items.Add(file);
                    }
                }
            }
        }

        private void merge_files_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(outputPath))
            {
                MessageBox.Show("Please select a location to save the merged file.");
                return;
            }

            progress_bar.Maximum = file_list.Items.Count; // Total number of files
            progress_bar.Value = progress_bar.Minimum; // Reset the progress bar

            try
            {
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    bool headerWritten = false;

                    foreach (string filePath in file_list.Items) // Assuming the file paths are stored in a ListBox
                    {
                        bool isCompressed = filePath.EndsWith(".gz");

                        using (Stream fileStream = File.OpenRead(filePath))
                        {
                            Stream stream = isCompressed ? (Stream)new GZipStream(fileStream, CompressionMode.Decompress) : fileStream;

                            using (StreamReader reader = new StreamReader(stream))
                            {
                                string line;
                                bool isFirstLine = true;

                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (isFirstLine)
                                    {
                                        if (!headerWritten)
                                        {
                                            writer.WriteLine(line); // Write the header from the first file
                                            headerWritten = true;
                                        }
                                        isFirstLine = false;
                                    }
                                    else
                                    {
                                        writer.WriteLine(line); // Write data rows
                                    }
                                }
                            }
                        }
                        progress_bar.PerformStep(); //Increment progress bar based on number of files processed
                    }
                }

                MessageBox.Show("Files merged successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void save_to_location_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "TSV files (*.tsv)|*.tsv";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputPath = saveFileDialog.FileName;
                }
            }
        }
    }
}
