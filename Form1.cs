using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SeninBorcun
{
    public partial class Form1 : Form
    {
        private List<string[]> dialogues;
        private int currentDialogueIndex = 0;

        public Form1()
        {
            InitializeComponent();
            LoadDialogues();
            ShowNextScene();
        }

        private void LoadDialogues()
        {
            dialogues = new List<string[]>();

            // Dosyadan diyalogları oku
            string[] lines = File.ReadAllLines("data/dialogues.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3) // Konuşan, yüz, sinematik dosyaları
                {
                    dialogues.Add(parts);
                }
            }
        }

        private void ShowNextScene()
        {
            if (currentDialogueIndex >= dialogues.Count)
            {
                Application.Exit(); // Oyun bittiğinde kapan
                return;
            }

            string speaker = dialogues[currentDialogueIndex][0];   // Konuşan kişi
            string facePath = dialogues[currentDialogueIndex][1];  // Yüz resmi
            string scenePath = dialogues[currentDialogueIndex][2]; // Sinematik PNG

            dialogLabel.Text = speaker; // Konuşmacıyı yaz
            facePictureBox.Image = Image.FromFile($"data/face/{facePath}"); // Yüzü göster
            scenePictureBox.Image = Image.FromFile($"data/cinematics/{scenePath}"); // Sinematiği göster

            currentDialogueIndex++;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Boşluk tuşuna basınca sonraki sahne
            {
                ShowNextScene();
            }
        }
    }
}
