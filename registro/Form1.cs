using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;
using static registro.Form1;

namespace registro
{
    public partial class Form1 : Form
    {
        public class Voti
        {
            public List<int> italiano;
            public List<int> storia;
            public List<int> matematica;
            public List<int> inglese;
            public List<int> informatica;
            public List<int> sistemi;
            public List<int> tpsit;
            public List<int> telecomunicazioni;
        }

        public class Studente
        {
            public int matricola;
            public string nome;
            public string cognome;
            public DateTime dataNascita;
            public string luogoNascita;
            public string classe;
            public Voti voti;
        }

        public class Docente
        {
            public int matricola;
            public string nome;
            public string cognome;
        }

        string studentiFile = "../../studenti.json";
        Studente[] studenti;
        string docentiFile = "../../docenti.json";
        Docente[] docenti;

        Studente studenteSelezionato;

        public Form1()
        {
            InitializeComponent();

            studenti = JsonConvert.DeserializeObject<Studente[]>(File.ReadAllText(studentiFile));
            docenti = JsonConvert.DeserializeObject<Docente[]>(File.ReadAllText(docentiFile));

            foreach (Studente studente in studenti)
            {
                studenteVoti.Items.Add(studente.nome + " " + studente.cognome);
            }
        }

        private void loginStudente_Click(object sender, EventArgs e)
        {
            if (loginStudente.Text == "Logout")
            {
                matricolaStudente.Enabled = true;
                nomeStudente.Enabled = true;
                cognomeStudente.Enabled = true;
                loginStudente.Text = "Login";

                matricolaDocente.Enabled = true;
                nomeDocente.Enabled = true;
                cognomeDocente.Enabled = true;
                loginDocente.Enabled = true;

                dataGrid.ColumnHeadersVisible = false;
                dataGrid.Rows.Clear();

                return;
            }

            foreach (Studente studente in studenti)
            {
                if (studente.matricola == Convert.ToInt32(matricolaStudente.Text) && studente.nome == nomeStudente.Text && studente.cognome == cognomeStudente.Text)
                {
                    matricolaStudente.Enabled = false;
                    nomeStudente.Enabled = false;
                    cognomeStudente.Enabled = false;
                    loginStudente.Text = "Logout";

                    matricolaDocente.Enabled = false;
                    nomeDocente.Enabled = false;
                    cognomeDocente.Enabled = false;
                    loginDocente.Enabled = false;

                    caricaVoti(studente);

                    return;
                }
            }

            MessageBox.Show("Credenziali Errate.");
        }

        private void loginDocente_Click(object sender, EventArgs e)
        {
            if (loginDocente.Text == "Logout")
            {
                matricolaStudente.Enabled = true;
                nomeStudente.Enabled = true;
                cognomeStudente.Enabled = true;
                loginStudente.Enabled = true;

                matricolaDocente.Enabled = true;
                nomeDocente.Enabled = true;
                cognomeDocente.Enabled = true;
                loginDocente.Text = "Login";

                studenteVoti.Enabled = false;
                materiaAggiungi.Enabled = false;
                votoAggiungi.Enabled = false;
                aggiungi.Enabled = false;
                materiaElimina.Enabled = false;
                votoElimina.Enabled = false;
                elimina.Enabled = false;

                dataGrid.ColumnHeadersVisible = false;
                dataGrid.Rows.Clear();

                return;
            }

            foreach (Docente docente in docenti)
            {
                if (docente.matricola == Convert.ToInt32(matricolaDocente.Text) && docente.nome == nomeDocente.Text && docente.cognome == cognomeDocente.Text)
                {
                    matricolaStudente.Enabled = false;
                    nomeStudente.Enabled = false;
                    cognomeStudente.Enabled = false;
                    loginStudente.Enabled = false;

                    matricolaDocente.Enabled = false;
                    nomeDocente.Enabled = false;
                    cognomeDocente.Enabled = false;
                    loginDocente.Text = "Logout";

                    studenteVoti.Enabled = true;
                    materiaAggiungi.Enabled = true;
                    votoAggiungi.Enabled = true;
                    aggiungi.Enabled = true;
                    materiaElimina.Enabled = true;
                    votoElimina.Enabled = true;
                    elimina.Enabled = true;

                    caricaVoti(studenteSelezionato);

                    return;
                }
            }

            MessageBox.Show("Credenziali Errate.");
        }

        private void studenteVoti_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Studente studente in studenti)
            {
                if (studente.nome + " " + studente.cognome == studenteVoti.Text)
                {
                    studenteSelezionato = studente;
                    caricaVoti(studenteSelezionato);

                    break;
                }
            }
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            if (studenteSelezionato == null)
            {
                MessageBox.Show("Seleziona uno studente.");
                return;
            }

            if (materiaAggiungi.Text == "Italiano")
            {
                studenteSelezionato.voti.italiano.Add((int)votoAggiungi.Value);
            }
            else if (materiaAggiungi.Text == "Storia")
            {
                studenteSelezionato.voti.storia.Add((int)votoAggiungi.Value);
            }
            else if (materiaAggiungi.Text == "Matematica")
            {
                studenteSelezionato.voti.matematica.Add((int)votoAggiungi.Value);
            }
            else if (materiaAggiungi.Text == "Inglese")
            {
                studenteSelezionato.voti.inglese.Add((int)votoAggiungi.Value);
            }
            else if (materiaAggiungi.Text == "Informatica")
            {
                studenteSelezionato.voti.informatica.Add((int)votoAggiungi.Value);
            }
            else if (materiaAggiungi.Text == "Sistemi e Reti")
            {
                studenteSelezionato.voti.sistemi.Add((int)votoAggiungi.Value);
            }
            else if (materiaAggiungi.Text == "TPSIT")
            {
                studenteSelezionato.voti.tpsit.Add((int)votoAggiungi.Value);
            }
            else if (materiaAggiungi.Text == "Telecomunicazioni")
            {
                studenteSelezionato.voti.telecomunicazioni.Add((int)votoAggiungi.Value);
            }
            else
            {
                MessageBox.Show("Seleziona una materia.");
            }

            caricaVoti(studenteSelezionato);
            File.WriteAllText(studentiFile, JsonConvert.SerializeObject(studenti, Formatting.Indented));
        }

        private void materiaElimina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studenteSelezionato == null)
            {
                MessageBox.Show("Seleziona uno studente.");
                return;
            }

            votoElimina.Items.Clear();
            if (materiaElimina.Text == "Italiano")
            {
                foreach (int voto in studenteSelezionato.voti.italiano)
                {
                    votoElimina.Items.Add(voto);
                }
            }
            else if (materiaElimina.Text == "Storia")
            {
                foreach (int voto in studenteSelezionato.voti.storia)
                {
                    votoElimina.Items.Add(voto);
                }
            }
            else if (materiaElimina.Text == "Matematica")
            {
                foreach (int voto in studenteSelezionato.voti.matematica)
                {
                    votoElimina.Items.Add(voto);
                }
            }
            else if (materiaElimina.Text == "Inglese")
            {
                foreach (int voto in studenteSelezionato.voti.inglese)
                {
                    votoElimina.Items.Add(voto);
                }
            }
            else if (materiaElimina.Text == "Informatica")
            {
                foreach (int voto in studenteSelezionato.voti.informatica)
                {
                    votoElimina.Items.Add(voto);
                }
            }
            else if (materiaElimina.Text == "Sistemi e Reti")
            {
                foreach (int voto in studenteSelezionato.voti.sistemi)
                {
                    votoElimina.Items.Add(voto);
                }
            }
            else if (materiaElimina.Text == "TPSIT")
            {
                foreach (int voto in studenteSelezionato.voti.tpsit)
                {
                    votoElimina.Items.Add(voto);
                }
            }
            else if (materiaElimina.Text == "Telecomunicazioni")
            {
                foreach (int voto in studenteSelezionato.voti.telecomunicazioni)
                {
                    votoElimina.Items.Add(voto);
                }
            }
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            if (studenteSelezionato == null)
            {
                MessageBox.Show("Seleziona uno studente.");
                return;
            }

            int voto;
            try
            {
                voto = Convert.ToInt32(votoElimina.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Seleziona un voto");
                return;
            }

            if (materiaElimina.Text == "Italiano")
            {
                studenteSelezionato.voti.italiano.Remove(voto);
            }
            else if (materiaElimina.Text == "Storia")
            {
                studenteSelezionato.voti.storia.Remove(voto);
            }
            else if (materiaElimina.Text == "Matematica")
            {
                studenteSelezionato.voti.matematica.Remove(voto);
            }
            else if (materiaElimina.Text == "Inglese")
            {
                studenteSelezionato.voti.inglese.Remove(voto);
            }
            else if (materiaElimina.Text == "Informatica")
            {
                studenteSelezionato.voti.informatica.Remove(voto);
            }
            else if (materiaElimina.Text == "Sistemi e Reti")
            {
                studenteSelezionato.voti.sistemi.Remove(voto);
            }
            else if (materiaElimina.Text == "TPSIT")
            {
                studenteSelezionato.voti.tpsit.Remove(voto);
            }
            else if (materiaElimina.Text == "Telecomunicazioni")
            {
                studenteSelezionato.voti.telecomunicazioni.Remove(voto);
            }
            else
            {
                MessageBox.Show("Seleziona una materia.");
            }

            caricaVoti(studenteSelezionato);
            File.WriteAllText(studentiFile, JsonConvert.SerializeObject(studenti, Formatting.Indented));
        }

        private void caricaVoti(Studente studente)
        {
            if (studente == null)
            {
                return;
            }

            dataGrid.Rows.Clear();
            dataGrid.ColumnHeadersVisible = true;

            List<List<int>> arrayMaterie = new List<List<int>>
            {
                studente.voti.italiano,
                studente.voti.storia,
                studente.voti.matematica,
                studente.voti.inglese,
                studente.voti.informatica,
                studente.voti.sistemi,
                studente.voti.tpsit,
                studente.voti.telecomunicazioni
            };

            int numeroRighe = arrayMaterie.Max(subject => subject.Count);

            List<string[]> arrayVoti = new List<string[]>();
            foreach (var materia in arrayMaterie)
            {
                string[] arrayVotiMateria = new string[numeroRighe];
                for (int i = 0; i < numeroRighe; i++)
                {
                    if (i < materia.Count)
                    {
                        arrayVotiMateria[i] = materia[i].ToString();
                    }
                    else
                    {
                        arrayVotiMateria[i] = " ";
                    }
                }
                arrayVoti.Add(arrayVotiMateria);
            }

            // Add rows to the dataGrid
            for (int i = 0; i < numeroRighe; i++)
            {
                dataGrid.Rows.Add(arrayVoti.Select(voti => voti[i]).ToArray());
            }
        }
    }
}