using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace One_lesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            List<Button> buttons = new List<Button>();

            for (int i = 0; i < 5; i++)
            {
                int buttonIndex = i;
                Button button = new Button
                {
                    Location = new System.Drawing.Point(20 + i * 235, 20),
                    Size = new System.Drawing.Size(244, 31),
                    FlatStyle = FlatStyle.Flat,
                    TabIndex = i,
                    BackColor = Color.Transparent // Make the button background transparent
                };
                button.FlatAppearance.BorderSize = 0;

                // Create a PictureBox to display the SVG image
                PictureBox pictureBox = new PictureBox
                {
                    Location = new System.Drawing.Point(0, 0),
                    Size = new Size(244, 31),
                    BackColor = Color.Transparent // Make the PictureBox background transparent
                };

                // Load the SVG image into the PictureBox (Replace "your_svg_image.svg" with your SVG file)
                pictureBox.Load("Resources/tab.png");

                // Add the PictureBox to the button
                button.Controls.Add(pictureBox);

                // Add the event handler using the captured buttonIndex
                button.Click += (sender, e) =>
                {
                    MessageBox.Show("Button " + (buttonIndex + 1) + " clicked");
                };
                pictureBox.Click += (sender, e) =>
                {
                    MessageBox.Show("Button " + (buttonIndex + 1) + " clicked");
                };

                buttons.Add(button);
                Controls.Add(button);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
