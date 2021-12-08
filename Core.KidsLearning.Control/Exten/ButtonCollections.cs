using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Core.KidsLearning.Control.Exten
{
     /**/
        public class ButtonCollections : UserControl
    {
        public ButtonCollections()
        {
            RefreshGrid();
            MyProperties = new MyProperties();
        }
        public MyProperties MyProperties { get; set; }
        int sizeX = 10; int sizeY = 10;
        int rowCount = 2;
        int ColumnCount = 2;
        Size _ButtonSize = new Size(300, 140);
        Color _ButtonColor =  System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
        Color _ButtonForeColor = System.Drawing.Color.Blue;
        public void RefreshGrid()
        {
            if (rowCount <= 0 || ColumnCount <= 0) return;
            this.Controls.Clear();
            int X = 20, Y = 20;
            int row = 0, column = 0;
            for (int i = 1; i <= rowCount * ColumnCount; i++)
            {
                Button btn = new Button();
                btn.BackColor = _ButtonColor;
                btn.Font = this.Font;
                btn.ForeColor = _ButtonForeColor;
                btn.Location = new System.Drawing.Point(X, Y);
                btn.Name = "button" + column + "_" + row;
                btn.Size = _ButtonSize;
                btn.Text = btn.Name;
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(buttonChoie_Click);
                X += _ButtonSize.Width + sizeX;
                this.Controls.Add(btn);
                column++;
                if (i % ColumnCount == 0)
                {
                    Y += _ButtonSize.Height + sizeY; X = 20;
                    column = 0;
                    row++;
                }

            }
        }

        private void buttonChoie_Click(object sender, EventArgs e)
        {
            ButtonSelect = sender as Button;
        }


        #region _Property
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.Category("TOR Setting")]
        public Font ButtonFont
        {
            get { return this.Font; }
            set
            {
                this.Font = value;
                RefreshGrid();
            }
        }
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.Category("TOR Setting")]
        public Color ButtonColor
        {
            get { return _ButtonColor; }
            set
            {
                _ButtonColor = value;
                RefreshGrid();
            }
        }
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.Category("TOR Setting")]
        public Color ButtonForeColor
        {
            get { return _ButtonForeColor; }
            set
            {
                _ButtonForeColor = value;
                RefreshGrid();
            }
        }
        
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.DefaultValue(2)]
        [System.ComponentModel.Category("TOR Setting")]
        public int rowCounts
        {
            get { return rowCount; }
            set
            {
                rowCount = value;
                RefreshGrid();
            }
        }
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.Category("TOR Setting")]
        public Size ButtonSize
        {
            get { return _ButtonSize; }
            set
            {
                _ButtonSize = value;
                RefreshGrid();
            }
        }
        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always)]
        [System.ComponentModel.DefaultValue(2)]
        [System.ComponentModel.Category("TOR Setting")]
        public int ColumnCounts
        {
            get { return ColumnCount; }
            set
            {
                ColumnCount = value;
                RefreshGrid();
            }
        }
         public Button Item(int row,int column)
        {
           return  this.Controls.Find("button" + column + "_" + row,true).FirstOrDefault() as Button;
        }
        public virtual void Clear()
        {
            this.Controls.Clear();
        }
        #endregion
        public Button ButtonSelect;
        public event EventHandler ButtonClick
        {
            add
            {
                for (int r = 0; r < rowCount; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {
                        if (value != null && Item(r, c) != null)
                        Item(r, c).Click += value;
                    }
                }
            }
            remove
            {
                for (int r = 0; r < rowCount; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {
                        if (value != null && Item(r, c) != null)
                        Item(r, c).Click -= value;
                    }
                }
            }
        }
        
    }
}