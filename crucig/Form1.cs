using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace crucig
{
    public partial class Form1 : Form
    {
        private string imagenJugador1;
        string imagenJugador2;
        private int tiempoPorPartida;
        private int partidaTiempoRestante;
        private int tiempoPorTurno;
        private string nombreJugador1;
        private string nombreJugador2;
        private bool fotosSeleccionada = false;
        private bool fotosSeleccionada2 = false;
        private List<Tuple<int, int, char>> respuestasCorrectas;
        private bool esTurnoJugador1 = true;
        private List<string> palabrasCorrectas;
        private int puntuacionJugador1 = 0;
        private int puntuacionJugador2 = 0;
        private List<string> palabrasAdivinadas;

        class Word
        {
            public string Text { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public int Length { get; set; }
            public char Direction { get; set; }
            public string Clue { get; set; }

            public Word(string text, int x, int y, int length, char direction, string clue)
            {
                Text = text;
                X = x;
                Y = y;
                Length = length;
                Direction = direction;
                Clue = clue;
            }
        }

        private bool TryPlaceWord(Word word, bool[,] board)
        {
            int dx = word.Direction == 'H' ? 1 : 0;
            int dy = word.Direction == 'V' ? 1 : 0;

            for (int i = 0; i < word.Text.Length; i++)
            {
                int x = word.X + i * dx;
                int y = word.Y + i * dy;

                if (x < 0 || x >= board.GetLength(0) || y < 0 || y >= board.GetLength(1) || board[x, y])
                {
                    return false;
                }
            }

            for (int i = 0; i < word.Text.Length; i++)
            {
                int x = word.X + i * dx;
                int y = word.Y + i * dy;
                board[x, y] = true;
            }

            return true;
        }

        private bool PlaceWords(List<Word> words, bool[,] board, int index = 0)
        {
            if (index == words.Count)
            {
                return true;
            }

            Word word = words[index];

            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    word.X = x;
                    word.Y = y;

                    if (TryPlaceWord(word, board))
                    {
                        if (PlaceWords(words, board, index + 1))
                        {
                            return true;
                        }

                        // Backtrack
                        for (int i = 0; i < word.Text.Length; i++)
                        {
                            int dx = word.Direction == 'H' ? 1 : 0;
                            int dy = word.Direction == 'V' ? 1 : 0;
                            board[word.X + i * dx, word.Y + i * dy] = false;
                        }
                    }
                }
            }

            return false;
        }
        private List<Word> ObtenerPalabrasAleatorias(string path, int cantidadPalabras)
        {
            var palabras = new List<Word>();
            var lineas = File.ReadAllLines(path);

            // Esto supone que el archivo tiene al menos una línea
            var random = new Random();

            // Selección de líneas aleatorias únicas
            var lineasSeleccionadas = new HashSet<int>();
            while (lineasSeleccionadas.Count < cantidadPalabras)
            {
                lineasSeleccionadas.Add(random.Next(lineas.Length));
            }

            foreach (int indiceLinea in lineasSeleccionadas)
            {
                var lineaAleatoria = lineas[indiceLinea];

                // Leer la línea seleccionada y obtener las palabras y sus posiciones
                var tokens = lineaAleatoria.Split(',');
                for (int i = 0; i < tokens.Length; i += 6)
                {
                    palabras.Add(new Word(
                        tokens[i],
                        int.Parse(tokens[i + 1]),
                        int.Parse(tokens[i + 2]),
                        int.Parse(tokens[i + 3]),
                        tokens[i + 4][0],
                        tokens[i + 5]
                    ));
                }
            }

            return palabras;
        }

        private List<Control> CrearCrucigrama(List<Word> palabras)
        {
            respuestasCorrectas = new List<Tuple<int, int, char>>();

            List<Control> controles = new List<Control>();
            respuestasCorrectas.Clear(); // Limpiar la lista de respuestas correctas

            int numeroPalabra = 1;
            int filaActual = 0;
            int columnaActual = 0;
            foreach (Word palabra in palabras)
            {
                string texto = palabra.Text;
                int x = columnaActual * 2 + 1;
                int y = filaActual * 2 + 1;
                char direccion = numeroPalabra % 2 == 0 ? 'V' : 'H';

                Label numeroLabel = new Label();
                numeroLabel.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                numeroLabel.Location = new Point(x * 30 - 15, y * 30 + 40);
                numeroLabel.Name = $"labelNumero{numeroPalabra}";
                numeroLabel.Size = new Size(15, 15);
                numeroLabel.TabIndex = 0;
                numeroLabel.Text = numeroPalabra.ToString();
                numeroLabel.TextAlign = ContentAlignment.MiddleRight;
                numeroLabel.ForeColor = Color.White;
                controles.Add(numeroLabel);

                for (int i = 0; i < texto.Length; i++)
                {
                    int posX = direccion == 'H' ? x + i : x;
                    int posY = direccion == 'H' ? y : y + i;

                    TextBox textBox = new TextBox();
                    textBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    textBox.Location = new Point(posX * 30, posY * 30 + 35);
                    textBox.MaxLength = 1;
                    textBox.Name = $"textBox{x}_{y}_{direccion}{i}";
                    textBox.Size = new Size(30, 30);
                    textBox.TabIndex = 0;
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.ReadOnly = true; // Hacer que el TextBox sea de solo lectura
                    textBox.Text = "";
                    textBox.Tag = new Tuple<string, int>(texto, i);
                    controles.Add(textBox);

                    // Almacenar la respuesta correcta
                    respuestasCorrectas.Add(new Tuple<int, int, char>(posX, posY, texto[i]));
                }
                palabrasCorrectas = ExtraerPalabrasCorrectas(respuestasCorrectas);
                numeroPalabra++; // Incrementar el número de palabra

                if (direccion == 'H')
                {
                    filaActual++;
                }
                else
                {
                    columnaActual++;
                }
            }

            return controles;
        }



        private void CambiarTurno()
        {
            // Detener el temporizador de turno
            timerTurno.Stop();

            // Reiniciar variable de palabra resuelta
            palabraResuelta = false;
            textPalabra.Clear();
            btnCheck.Enabled = true;

            // Cambiar el turno del jugador
            esTurnoJugador1 = !esTurnoJugador1;

            // Actualizar la etiqueta del jugador actual
            labelJugadorActual.Text = esTurnoJugador1 ? nombreJugador1 : nombreJugador2;

            // Reiniciar el temporizador de turno
            tiempoRestanteTurno = tiempoPorTurno;
            labelTiempoTurnoRestante.Text = TimeSpan.FromSeconds(tiempoPorTurno).ToString(@"mm\:ss");
            timerTurno.Start();
        }



        private int tiempoRestanteTurno;
        private bool bloqueoEvento = false;


        private void timerTurno_Tick(object sender, EventArgs e)
        {
            if (bloqueoEvento)
            {
                return;
            }

            // Establecer el bloqueo de evento
            bloqueoEvento = true;

            // Restar un segundo al tiempo restante de turno
            tiempoRestanteTurno--;


            labelTiempoTurnoRestante.Text = TimeSpan.FromSeconds(tiempoRestanteTurno).ToString(@"mm\:ss");

            if (tiempoRestanteTurno == 0)
            {
                CambiarTurno();
            }

            // Reiniciar el temporizador de turno
            if (tiempoRestanteTurno > 0)
            {
                labelTiempoTurnoRestante.Text = TimeSpan.FromSeconds(tiempoRestanteTurno).ToString(@"mm\:ss");
                timerTurno.Start();
            }

            // Liberar el bloqueo de evento
            bloqueoEvento = false;
        }

        private void ActualizarPuntuacion(bool esJugador1, int puntos)
        {
            if (esJugador1)
            {
                puntuacionJugador1 += puntos;
                labelPuntuacionJugador1.Text = $"{puntuacionJugador1}";
            }
            else
            {
                puntuacionJugador2 += puntos;
                labelPuntuacionJugador2.Text = $"{puntuacionJugador2}";
            }
        }
        public Form1()
        {
            InitializeComponent();
            palabrasAdivinadas = new List<string>();
            btnCheck.Click += BtnCheck_Click;
            tiempoPorPartida = tiempoPartida_default;
            tiempoPorTurno = tiempoTurno_default;
            btnJugarPartida.Enabled = false;

            timerTurno.Interval = 1000;
            timer1.Interval = 1000;
            timerTurno.Tick += timerTurno_Tick;
            respuestasCorrectas = new List<Tuple<int, int, char>>();
            partidaTiempoRestante = tiempoPorPartida;
        }
        private List<string> ExtraerPalabrasCorrectas(List<Tuple<int, int, char>> respuestasCorrectas)
        {
            List<string> palabrasCorrectas = new List<string>();
            StringBuilder palabra = new StringBuilder();

            for (int i = 0; i < respuestasCorrectas.Count; i++)
            {
                palabra.Append(respuestasCorrectas[i].Item3);

                bool nuevaPalabra = false;

                if (i < respuestasCorrectas.Count - 1)
                {
                    int dx = respuestasCorrectas[i + 1].Item1 - respuestasCorrectas[i].Item1;
                    int dy = respuestasCorrectas[i + 1].Item2 - respuestasCorrectas[i].Item2;
                    nuevaPalabra = (dx != 0 && dy != 0) || (dx > 1 || dy > 1);
                }

                if (i == respuestasCorrectas.Count - 1 || nuevaPalabra)
                {
                    palabrasCorrectas.Add(palabra.ToString());
                    palabra.Clear();
                }
            }

            return palabrasCorrectas;
        }

        private void MostrarPalabra(string palabra)
        {
            foreach (Control control in panelJuego.Controls)
            {
                if (control is TextBox textBox)
                {
                    Tuple<string, int> tag = textBox.Tag as Tuple<string, int>;
                    if (tag != null && tag.Item1 == palabra)
                    {
                        textBox.Text = tag.Item1[tag.Item2].ToString();
                        textBox.BackColor = Color.MediumSlateBlue;
                    }
                }
            }
        }

        private void btnTerminarTurno_Click(object sender, EventArgs e)
        {
            // Cambiar al otro jugador
            CambiarTurno();
        }
        bool palabraResuelta = false;

        private bool VerificarPalabras()
        {
            int tiempoTotalPartida = tiempoPorPartida - partidaTiempoRestante;
            // Obtener la palabra ingresada en el TextBox
            string palabraIngresada = textPalabra.Text.ToUpper();

            if (palabrasAdivinadas.Contains(palabraIngresada))
            {
                MessageBox.Show("Palabra ya existente.");
                return false;
            }
            else if (palabrasCorrectas.Contains(palabraIngresada))
            {
                palabrasAdivinadas.Add(palabraIngresada);
                MostrarPalabra(palabraIngresada);

            }
            else
            {
                return false;
            }

            List<string> palabrasCorrectasMinusculas = palabrasCorrectas.ConvertAll(p => p.ToLower());

            // Buscar la palabra ingresada en la lista de palabras correctas
            bool esCorrecta = palabrasCorrectas.Contains(palabraIngresada);

            Debug.WriteLine(palabrasCorrectas);

            btnCheck.Enabled = !esCorrecta;

            // Retornar true si la palabra es correcta, false si no lo es
            return esCorrecta;
        }

        private void palabrasTerminadas()
        {
            if (palabrasAdivinadas.Count == palabrasCorrectas.Count)
            {
                MessageBox.Show("Gracias por jugar!");
                TerminarPartida();
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (!palabraResuelta && VerificarPalabras())
            {
                MessageBox.Show("Palabra Correcta!");
                // Aquí asumimos que cada palabra acertada vale 1 punto
                ActualizarPuntuacion(esTurnoJugador1, 1);
                palabraResuelta = true;
                // No se agrega botón para indicar que ya se adivinó
                // la palabra porque por regla solo se puede responder una palabra.
                // directamente se cambia el turno.
                palabrasTerminadas();
                CambiarTurno();
            }
            else if (palabraResuelta)
            {
                MessageBox.Show("Ya se ha resuelto una palabra durante este turno.");
                palabrasTerminadas();
            }
            else
            {
                textPalabra.Clear();
                MessageBox.Show("Palabra incorrecta");
                palabrasTerminadas();
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            panelConfiguracion.Visible = true;
            panelJuego.Visible = false;
            panelResultados.Visible = false;
        }


        private void btnResultados_Click(object sender, EventArgs e)
        {
            panelConfiguracion.Visible = false;
            panelJuego.Visible = false;
            panelResultados.Visible = true;
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            // Almacenar el tiempo de la partida y el tiempo por turno
            tiempoPorPartida = (int)tiempoPartida.Value;
            tiempoPorTurno = (int)tiempoTurno.Value;

            // Si el tiempo de la partida o el tiempo por turno es 0, asignar los valores predeterminados
            if (tiempoPorPartida == 0)
            {
                tiempoPorPartida = tiempoPartida_default;
            }
            if (tiempoPorTurno == 0)
            {
                tiempoPorTurno = tiempoTurno_default;
            }

            Regex regex = new Regex("^[a-zA-Z\\s-]*$");
            if (!regex.IsMatch(nameJugador1.Text) || !regex.IsMatch(nameJugador2.Text))
            {
                MessageBox.Show("El nombre de usuario solo debe contener letras, espacios y guiones.");
                return;
            }

            List<string> palabrasProhibidas = new List<string> { "droga", "obsceno", "violencia", "crimen" };
            foreach (string palabra in palabrasProhibidas)
            {
                if (nameJugador1.Text.Contains(palabra) || nameJugador2.Text.Contains(palabra))
                {
                    MessageBox.Show("No se permiten nombres que contengan palabras inadecuadas.");
                    return;
                }
            }

            nombreJugador1 = nameJugador1.Text;
            nombreJugador2 = nameJugador2.Text;



            // Validar que los nombres no estén vacíos y que sean adecuados (puedes agregar tu propia función de validación aquí)
            if (string.IsNullOrWhiteSpace(nombreJugador1) || string.IsNullOrWhiteSpace(nombreJugador2))
            {
                MessageBox.Show("Por favor, ingrese nombres válidos para ambos jugadores.");
                return;
            }
            if (fotosSeleccionada && fotosSeleccionada2)
            {
                btnJugarPartida.Enabled = true;
            }
            else
            {
                MessageBox.Show("Por favor seleccione las fotos de perfil ");
                return;
            }
        }


        private void btnFoto1_Click(object sender, EventArgs e)
        {
            if (openFile1.ShowDialog() == DialogResult.OK)
            {
                // Aquí puedes guardar la ruta de la imagen seleccionada o cargar la imagen en un control PictureBox en tu formulario
                imagenJugador1 = openFile1.FileName;
                fotosSeleccionada = true;
            }
        }

        private void btnFoto2_Click(object sender, EventArgs e)
        {
            if (openFile1.ShowDialog() == DialogResult.OK)
            {
                // Aquí puedes guardar la ruta de la imagen seleccionada o cargar la imagen en un control PictureBox en tu formulario
                imagenJugador2 = openFile1.FileName;
                fotosSeleccionada2 = true;
            }
        }



        int tiempoPartida_default = 300; // 5 minutos en segundos
        int tiempoTurno_default = 90; // 90 segundos



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Restar un segundo al tiempo de partida
            partidaTiempoRestante--;

            // Actualizar la etiqueta del tiempo restante
            labelTiempoRestante.Text = TimeSpan.FromSeconds(partidaTiempoRestante).ToString(@"mm\:ss");

            // Comprobar si el tiempo de partida ha terminado
            if (partidaTiempoRestante <= 0)
            {
                timer1.Stop();
                timerTurno.Stop();
                TerminarPartida();
            }
        }

        private void ReiniciarPartida()
        {
            puntuacionJugador1 = 0;
            puntuacionJugador2 = 0;
            labelPuntuacionJugador1.Text = "0";
            labelPuntuacionJugador2.Text = "0";

            EliminarCrucigrama();
            IniciarPartida();
        }



        private void ReiniciarConfiguraciones()
        {
            puntuacionJugador1 = 0;
            puntuacionJugador2 = 0;
            labelPuntuacionJugador1.Text = "0";
            labelPuntuacionJugador2.Text = "0";

            // Establecer el jugador inicial
            esTurnoJugador1 = false;
            labelJugadorActual.Text = nombreJugador1;

            nameJugador1.Clear();
            nameJugador2.Clear();
            tiempoTurno.Value = 0;
            tiempoPartida.Value = 0;

        }

        private void TerminarPartida()
        {
            timer1.Stop();
            timerTurno.Stop();

            MostrarResultados();

            EliminarCrucigrama();
            ReiniciarConfiguraciones();
        }
        private string DeterminarEstadoJugador(int puntuacionJugador, int puntuacionOponente)
        {
            if (puntuacionJugador > puntuacionOponente)
            {
                return "Ganador";
            }
            else if (puntuacionJugador < puntuacionOponente)
            {
                return "Perdedor";
            }
            else
            {
                return "Empate";
            }
        }



        private Dictionary<string, Tuple<int, string, string>> resultados = new Dictionary<string, Tuple<int, string, string>>();


        private void MostrarResultados()
        {
            string estadoJugador1 = DeterminarEstadoJugador(puntuacionJugador1, puntuacionJugador2);
            string estadoJugador2 = DeterminarEstadoJugador(puntuacionJugador2, puntuacionJugador1);
            int tiempoTotal = tiempoPorPartida - partidaTiempoRestante;
            string tiempoTotalShow = TimeSpan.FromSeconds(tiempoTotal).ToString(@"mm\:ss");

            if (nombreJugador1 == nombreJugador2)
            {
                nombreJugador1 += " (1)";
                nombreJugador2 += " (2)";
            }

            if (resultados.ContainsKey(nombreJugador1))
            {
                resultados[nombreJugador1] = new Tuple<int, string, string>(puntuacionJugador1, tiempoTotalShow, estadoJugador1);
            }
            else
            {
                resultados.Add(nombreJugador1, new Tuple<int, string, string>(puntuacionJugador1, tiempoTotalShow, estadoJugador1));
            }

            if (resultados.ContainsKey(nombreJugador2))
            {
                resultados[nombreJugador2] = new Tuple<int, string, string>(puntuacionJugador2, tiempoTotalShow, estadoJugador2);
            }
            else
            {
                resultados.Add(nombreJugador2, new Tuple<int, string, string>(puntuacionJugador2, tiempoTotalShow, estadoJugador2));
            }

            var listaResultados = resultados.Select(r => new
            {
                Jugador = r.Key,
                PunteoTotal = r.Value.Item1,
                TiempoTotal = r.Value.Item2,
                Estado = r.Value.Item3
            }).ToList();

            dgvResultados.DataSource = listaResultados;

            if (!dgvResultados.Columns.Contains("Estado"))
            {
                DataGridViewTextBoxColumn columnaEstado = new DataGridViewTextBoxColumn
                {
                    Name = "Estado",
                    HeaderText = "Estado",
                    DataPropertyName = "Estado"
                };
                dgvResultados.Columns.Add(columnaEstado);
            }

            panelResultados.Visible = true;
            panelJuego.Visible = false;
            panelConfiguracion.Visible = false;
        }

        private void btnJugarPartida_Click_1(object sender, EventArgs e)
        {
            IniciarPartida();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            TerminarPartida();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            panelConfiguracion.Visible = false;
            panelJuego.Visible = false;
            panelResultados.Visible = false;
            panelPrincipal.Visible = false;
            panelMenuPrincipal.Visible = true;
        }
        private void IniciarPartida()
        {
            // Reiniciar la configuración de la partida
            partidaTiempoRestante = tiempoPorPartida;
            puntuacionJugador1 = 0;
            puntuacionJugador2 = 0;
            labelEstadisticasPlayer1.Text = nameJugador1.Text;
            labelEstadisticasPlayer2.Text = nameJugador2.Text;
            pictureJugador1.Image = Image.FromFile(imagenJugador1);
            pictureJugador2.Image = Image.FromFile(imagenJugador2);

            // Actualizar la etiqueta del tiempo restante
            labelTiempoRestante.Text = TimeSpan.FromSeconds(tiempoPorPartida).ToString(@"mm\:ss");

            // Iniciar el Timer
            timer1.Start();

            // Iniciar el Timer para los turnos y configurarlo

            tiempoRestanteTurno = tiempoPorTurno;
            labelTiempoTurnoRestante.Text = TimeSpan.FromSeconds(tiempoRestanteTurno).ToString(@"mm\:ss");

            timerTurno.Start();

            // Establecer el jugador inicial
            esTurnoJugador1 = true;
            labelJugadorActual.Text = nombreJugador1;

            int cantidadPalabras = 5;
            var palabrasAleatorias = ObtenerPalabrasAleatorias("C:\\Users\\Henry\\OneDrive\\Documentos\\dev\\proyecto_crucigrama\\crucig\\palabras.txt", cantidadPalabras);

            // Asignar números identificadores y definiciones a los labels
            for (int i = 0; i < cantidadPalabras; i++)
            {
                var palabra = palabrasAleatorias[i];

                // Asignar el número identificador al label 'n1', 'n2', etc.
                var numeroLabel = panelJuego.Controls.Find($"n{i + 1}", true).FirstOrDefault() as Label;
                if (numeroLabel != null)
                {
                    numeroLabel.Text = $"{i + 1}.";
                }

                // Asignar la definición al label 'definicion1', 'definicion2', etc.
                var definicionLabel = panelJuego.Controls.Find($"definicion{i + 1}", true).FirstOrDefault() as Label;

                if (definicionLabel != null)
                {
                    definicionLabel.Text = palabra.Clue; // La definición está en la posición 6 de la tupla
                }
            }

            var controlesCrucigrama = CrearCrucigrama(palabrasAleatorias);

            // Eliminar controles de crucigrama anteriores
            foreach (Control control in panelJuego.Controls.OfType<TextBox>().ToList())
            {
                if (control.Name.StartsWith("textBox"))
                {
                    panelJuego.Controls.Remove(control);
                }
            }

            // Agregar los nuevos controles al panel del juego
            foreach (Control control in controlesCrucigrama)
            {
                panelJuego.Controls.Add(control);
            }

            // Cambiar la visibilidad de los paneles
            panelConfiguracion.Visible = false;
            panelJuego.Visible = true;
            btnConfiguracion.Enabled = false;
            btnResultados.Enabled = false;
            btnJugarPartida.Enabled = false;
        }
        private void EliminarCrucigrama()
        {
            // Eliminar controles de crucigrama (TextBox y Label con números) del panel del juego
            foreach (Control control in panelJuego.Controls.OfType<TextBox>().ToList())
            {
                if (control.Name.StartsWith("textBox"))
                {
                    panelJuego.Controls.Remove(control);
                }
            }

            foreach (Control control in panelJuego.Controls.OfType<Label>().ToList())
            {
                if (control.Name.StartsWith("labelNumero"))
                {
                    panelJuego.Controls.Remove(control);
                }
            }

            respuestasCorrectas.Clear();
            palabrasCorrectas.Clear();
            palabrasAdivinadas.Clear();
        }

        private void btnReiniciarPartida_Click(object sender, EventArgs e)
        {
            ReiniciarPartida();

        }

        private void btnJugarAhoraMenuPrincipal_Click(object sender, EventArgs e)
        {
            panelMenuPrincipal.Visible = false;
            panelJuego.Visible = false;
            panelResultados.Visible = false;
            panelPrincipal.Visible = true;
            panelConfiguracion.Visible = true;
        }
    }
}