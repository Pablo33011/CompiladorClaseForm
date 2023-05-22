using CompiladorClaseForm.DataCache;
using CompiladorClaseForm.ErrorManager;
using CompiladorClaseForm.LexicalAnalyzer;
using System.Security.Policy;

namespace CompiladorClaseForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {

        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            Principal = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            TablaPalabrasReservadasgroupBox = new GroupBox();
            this.dataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            Principal.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            TablaPalabrasReservadasgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 64);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Buscar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(199, 457);
            button2.Name = "button2";
            button2.Size = new Size(136, 57);
            button2.TabIndex = 1;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Limpiar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(661, 457);
            button3.Name = "button3";
            button3.Size = new Size(136, 57);
            button3.TabIndex = 2;
            button3.Text = "Compilar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Compilar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(598, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += url_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(201, 99);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(596, 323);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += info_TextChanged;
            // 
            // Principal
            // 
            Principal.Controls.Add(tabPage1);
            Principal.Controls.Add(tabPage2);
            Principal.Controls.Add(tabPage3);
            Principal.Location = new Point(-3, 1);
            Principal.Name = "Principal";
            Principal.SelectedIndex = 0;
            Principal.Size = new Size(1031, 657);
            Principal.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1023, 624);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(TablaPalabrasReservadasgroupBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1023, 624);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1023, 625);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // TablaPalabrasReservadasgroupBox
            // 
            TablaPalabrasReservadasgroupBox.Controls.Add(this.dataGridView1);
            TablaPalabrasReservadasgroupBox.Location = new Point(3, 6);
            TablaPalabrasReservadasgroupBox.Name = "TablaPalabrasReservadasgroupBox";
            TablaPalabrasReservadasgroupBox.Size = new Size(822, 378);
            TablaPalabrasReservadasgroupBox.TabIndex = 0;
            TablaPalabrasReservadasgroupBox.TabStop = false;
            TablaPalabrasReservadasgroupBox.Text = "Tabla de Palabras Reservadas";
            TablaPalabrasReservadasgroupBox.Enter += TablaPalabrasReservadasgroupBox_Enter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] { this.Column1, this.Column2, this.Column3, this.Column4, this.Column5 });
            this.dataGridView1.Location = new Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new Size(678, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Número de Línea";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Posición Inicial";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Posición Final";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Categoría";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Lexema";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Form1
            // 
            ClientSize = new Size(1027, 659);
            Controls.Add(Principal);
            Name = "Form1";
            Principal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            TablaPalabrasReservadasgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            url.Text = ObtainUrl();
            if (url.Text.Contains(".XML") || url.Text.Contains(".xml") || url.Text.Contains(".html") || url.Text.Contains(".txt"))
            {
                StreamReader lector;
                try
                {
                    lector = File.OpenText(url.Text);
                    List<string> Lineas = new List<string>();
                    while (!lector.EndOfStream)
                    {
                        Lineas.Add(lector.ReadLine());
                    }
                    info.Lines = Lineas.ToArray();
                }
                catch (ArgumentException exp)
                {
                    Console.WriteLine("La ruta no debe estar vacia", exp.Message);
                }
            }
            else
            {
                MessageBox.Show("Esta extensión no está permitida");
                url.Clear();
            }
        }

        private String ObtainUrl()
        {
            string path = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;

            }
            return path;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            url.Clear();
            info.Clear();
            Cache.Clear();
            clearDataGrid(SimbolosdataGridView);
            clearDataGrid(LiteralesdataGridView);
            clearDataGrid(ReservadasdataGridView);
            clearDataGrid(dummiesDataGridView);
            clearDataGrid(ErrorDataGridVIew);
        }

        private void Compilar_Click(object sender, EventArgs e)
        {
            int index = 1;
            foreach (var linea in info.Lines)
            {
                Cache.AddLine(Line.Create(index, linea));
                index++;
            }
            LexicalAnalysis.Initialize();

            try
            {
                LexicalComponent component = LexicalAnalysis.Analyze();
                while (!Category.FIN_DE_ARCHIVO.Equals(component.GetCategory()))
                {
                    component = LexicalAnalysis.Analyze();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡¡¡ERROR DE COMPILACIÓN!!!");
                Console.WriteLine(ex.Message);
            }
            /*if (TablaMaestra.GetComponentsAsList(ComponentType.NORMAL).Count > 0)
            {
                Console.WriteLine("Simbolos: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.NORMAL))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            if (TablaMaestra.GetComponentsAsList(ComponentType.LITERAL).Count > 0)
            {
                Console.WriteLine("Literales: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.LITERAL))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            if (TablaMaestra.GetComponentsAsList(ComponentType.DUMMY).Count > 0)
            {
                Console.WriteLine("Dummies: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.DUMMY))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            if (TablaMaestra.GetComponentsAsList(ComponentType.PALABRA_RESERVADA).Count > 0)
            {
                Console.WriteLine("Palabras reservadas: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.PALABRA_RESERVADA))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }*/

            if (ErrorManagement.HayErrores())
            {
                Console.WriteLine("_________________________________________________________________");
                Console.WriteLine("LISTADO DE ERRORES LÉXICOS");
                Console.WriteLine("_________________________________________________________________");

                foreach (Error error in ErrorManagement.GetErrors(ErrorLevel.LEXICO))
                {
                    Console.WriteLine(error.ToString());
                    Console.WriteLine("_________________________________________________________________");
                    adicionarCeldaATablaErrores(error.GetType(), error.GetCause(), error.GetSolution(), error.GetExpectedCategory(), error.GetLineNumber(),
                        error.GetInitialPosition(), error.GetFinalPosition(), error.GetLexeme());
                }
            }
        }
        private void clearDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
        }

        private void url_TextChanged(object sender, EventArgs e)
        {

        }

        private void info_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TablaPalabrasReservadasgroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}