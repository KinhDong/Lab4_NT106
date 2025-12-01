using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_24520303_BuiCongDinh.Bai7
{
    public partial class RandomFood : Form
    {
        public RandomFood(FoodItem food)
        {
            InitializeComponent();

            FoodCard foodCard = new FoodCard(food);
            this.Controls.Add(foodCard);
        }
    }
}
