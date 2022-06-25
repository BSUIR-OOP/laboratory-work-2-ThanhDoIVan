using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly ShapeList _shapeList = new ShapeList();


        public class ShapeList: List<Shape>
        {
        }

        private readonly ComboBox cmbBox;

        public Form1()
        {
            InitializeComponent();
            cmbBox = new ComboBox()
            {
                Size = new Size(100, 20),
                Location = new Point(150, 0),
            };

            var shapes = typeof(Shape).Assembly.GetTypes();

            foreach (var type in shapes)
            {
                if (!type.IsAbstract && type.IsSubclassOf(typeof(Shape)))
                    _shapeList.Add((Shape)Activator.CreateInstance(type));
            }

            
            foreach (var item in _shapeList)
            {
                cmbBox.Items.Add(item);
            }
            
            cmbBox.SelectedIndexChanged += CmbBoxOnSelectedIndexChanged;
            
            Controls.Add(cmbBox);
            cmbBox.Hide();
        }

        private void CmbBoxOnSelectedIndexChanged(object sender, EventArgs e)
        {
            _shape = cmbBox.SelectedItem as Shape;
            if (_shape == null) return;
            
            foreach (Control control in Controls)
            {
                if (control is Panel)
                    Controls.Remove(control);
            }
            
            var p = new Panel()
            {
                Size = new Size(100, 100),
                Location = new Point(_locationclick.X - 50, _locationclick.Y - 50)
            };
            p.Paint += POnPaint;
            Controls.Add(p);    
        }

        private void POnPaint(object sender, PaintEventArgs e)
        {
            _shape.Draw(new GraphicsDrawable(e.Graphics));
        }

        private Shape _shape;
        private Point _locationclick;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            _locationclick = e.Location;

            foreach (Control control in Controls)
            {
                if (control is Panel)
                    Controls.Remove(control);
            }
            
            cmbBox.SelectedItem = null;
            
            cmbBox.Show();
            cmbBox.Focus();
            

        }
    }
}