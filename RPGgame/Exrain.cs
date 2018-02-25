using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Exrain
{
    public partial class Exrain : Form
    {
        private Player _player;
        
        public Exrain()
        {
            InitializeComponent();

            Location location = new Engine.Location(1, "Home", "This is your house.");
            location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house";

            _player = new Player(10, 10, 20, 0, 1);

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblMonero.Text = _player.Currency.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}
