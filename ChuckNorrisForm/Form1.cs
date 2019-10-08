﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ChuckNorrisForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_JokeGenerator_Click(object sender, EventArgs e)
        {
            Joke res = await ChuckNorrisClient.GetRandomJoke();
            txt_JokeResult.Text = res.JokeText;
        }

        private void txt_JokeResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
