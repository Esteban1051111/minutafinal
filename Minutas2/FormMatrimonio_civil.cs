using Word=Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;
using System.Globalization;

namespace Minutas2
{
    public partial class formMatrimonio_civil : Form
    {
        public formMatrimonio_civil()
        {


            InitializeComponent();
            cmbnotario_encargado.Items.Add("JORGE MANRIQUE ANDRADE (T)");
            cmbnotario_encargado.Items.Add("CLAUDIA MARCELA GRANADA (E)");
            cmbnotario_encargado.Items.Add("MARCELA PATIÑO PEÑA (E)");

            cmbtitular.Items.Add("Titular");
            cmbtitular.Items.Add("Encargado");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {




        }
        private void formMatrimonio_civil_Load(object sender, EventArgs e)
        {
            // Simula la copia de texto desde Word
            string textoDesdeWord = "Este es un texto desde Word con formato.";
            Clipboard.SetText(textoDesdeWord, TextDataFormat.Rtf);
        }

        private void btnvalidar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fecha_otorgamiento = dtfecha_otorgamiento.Text.ToUpper();


                string nombre_otorgante1 = txtnombre_otorgante1.Text.ToUpper();
                string cedula_otorgante1 = txt_ced_otorgante1.Text;
                string ciud_exp_otorgante1 = txt_ciud_otorgante1.Text.ToUpper();
                string lugar_naci_otorgante1 = txtlugar_naci_otorgante1.Text.ToUpper();
                string fecha_naci_otorgante1 = dtfecha_naci_otorgante1.Text.ToUpper();


                string nombre_otorgante2 = txtnombre_otorgante2.Text.ToUpper();
                string cedula_otorgante2 = txt_ced_otorgante2.Text;
                string ciud_expd_otorgante2 = txt_ciud_otorgante2.Text.ToUpper();
                string lugar_naci_otorgante2 = txtlugar_naci_otorgante2.Text.ToUpper();
                string fecha_naci_otorgante2 = dtfecha_naci_otorgante2.Text.ToUpper();


                string minuta;
                string num_hojas1 = txtnum_hojas1.Text.ToUpper();
                string num_hojas2 = txtnum_hojas2.Text.ToUpper();
                string indicativo_serial = txtindicativo_serial.Text;
                string recaudo = txtrecaudo.Text;
                string acto = txtacto.Text;
                string derechos = txtderechos.Text;
                string iva = txtiva.Text;
                string elaboro = txtelaboro.Text.ToUpper();
                string firmas = txtfirmas.Text.ToUpper();
                string notario_encargado = cmbnotario_encargado.SelectedItem.ToString();
                string titular = cmbtitular.SelectedItem.ToString();
                string num_escritura = txtnumescritura.Text;

                DateTime fecha = ObtenerFechaDesdeCadena(fecha_otorgamiento);
                string cadenaFechaFormateada = FormatearFecha(fecha);

                int numero_letras = int.Parse(num_escritura);
                string numero_letras2 = ConvertirNumeroAPalabras(numero_letras).ToUpper();

                minuta = "ESCRITURA PÚBLICA NÚMERO: {{\\b {" + num_escritura + "}}}-------------------------\r\nFECHA: " + fecha_otorgamiento + "-----\r\nCLASE DE ACTO: " + acto + ". ---------------------------------------------------------\r\nOTORGANTES: " + nombre_otorgante1 + ", IDENTIFICADO CON LA CÉDULA DE CIUDADANÍA NÚMERO " + cedula_otorgante1 + " EXPEDIDA EN " + ciud_exp_otorgante1 + ", Y " + nombre_otorgante2 + ", IDENTIFICADA CON LA CÉDULA DE CIUDADANÍA NÚMERO " + cedula_otorgante2 + " EXPEDIDA EN \r\n+ " + ciud_expd_otorgante2 + ". -------------------NOTARÍA DE ORIGEN: NOTARÍA SEGUNDA DE MANIZALES. -------------------------\r\nEn el municipio de Manizales, capital del departamento de Caldas, República de Colombia, al " + cadenaFechaFormateada + ", en el despacho de la NOTARIA SEGUNDA DEL CÍRCULO DE MANIZALES a cargo del Notario(a) " + titular + " " + notario_encargado + ", --------------------------------Comparecieron, el señor(a) " + nombre_otorgante1 + ", mayor de edad, vecino de Manizales, identificado con la cédula de ciudadanía número " + cedula_otorgante1 + " expedida en " + ciud_exp_otorgante1 + ", nacido en " + lugar_naci_otorgante1 + ", el día " + fecha_naci_otorgante1 + " de nacionalidad Colombiana y quien en la presente escritura se llamará EL CONTRAYENTE; y la señora " + nombre_otorgante2 + ", mayor de edad, vecino(a) de Manizales, identificado(a) con la cédula de ciudadanía número " + cedula_otorgante2 + " expedida en " + ciud_expd_otorgante2 + "., nacida en " + lugar_naci_otorgante2 + ", el día " + fecha_naci_otorgante1 + ", de nacionalidad Colombiana y quien en la presente escritura se llamará LA CONTRAYENTE; hábiles para contratar y obligarse, y dijeron: PRIMERO: Que en su entero y cabal juicio, es su deseo contraer matrimonio civil de conformidad con las prescripciones contenidas en el Decreto 2668 del 26 de Diciembre de 1.988. SEGUNDO: Que para tal efecto presentaron solicitud escrita y sus anexos, ante este despacho, todo lo cual se protocoliza con este instrumento público. TERCERO: Que constituidos en Audiencia Pública, el(la) Suscrito(a) Notario(a) preguntó claramente a los contrayentes si mediante el presente contrato de matrimonio, sin apremios de ninguna naturaleza, se quieren unir libre y espontáneamente, con el fin de formar una familia, vivir juntos, guardarse fe, socorrerse, procrear y ayudarse mutuamente en todas las circunstancias de la vida, con la afirmación de que el amor deberá presidir las relaciones entre los dos seres que por ministerio de la Ley quedan unidos en legítimo matrimonio ante la comunidad, procurando, con toda discreción y ternura, corregirse recíprocamente sus defectos, practicar la tolerancia y proceder en todos los casos con generosidad, equidad y templanza, evitando que entre ellos como esposos se presenten agravios de palabra o de obra que por su naturaleza irremediable comprometen la estabilidad del matrimonio, como comunión permanente entre dos seres que acuerdan transitar juntos el camino de la vida, como serían los hijos que llegaren a tener, preguntas y postulados anteriores todos los cuales los contrayentes, habiendo escuchado muy atentamente la lectura de esta escritura, manifiestan a el(la) Suscrito(a) Notario(a), con voz clara y perceptible que la han entendido completamente y por ello la aceptan y cumplirán íntegramente dichos postulados.- Agregan los contrayentes que el amor que los ha determinado para acogerse al vínculo matrimonial establecido por la Ley y por la  sociedad civil para perpetuar la especie les servirá para que en el transcurso de su vida estimulen una aproximación cada vez más estrecha entre  ellos  como  marido  y  mujer, para  así  entregarse por  entero  el  uno  al otro para la formación de la familia, con el pleno sentido de las responsabilidades que adquieren entre sí, para con sus  descendientes y frente a la comunidad a la cual pertenecen. Cada cual aportará su contingente, según las necesidades de la familia, para  constituirse en elementos de progreso ante la sociedad a la cual deberán  entregar, en el futuro, hijos y ciudadanos formados y educados en una atmósfera propicia para ser útiles a la familia, a la sociedad y a la patria; procurarán, en todo momento, que lo que ambos desearon al unirse en matrimonio no vaya a desmentirse  por  duras  que  sean  las  circunstancias que se les presente en el transcurso de su vida matrimonial.- CUARTO: Manifiestan los contrayentes al(la) Suscrito(a) Notario(a) que no tienen impedimento alguno para contraer matrimonio y que entre ellos no existe parentesco que pueda obstaculizarlo. – QUINTO: Que, en consecuencia, a partir de hoy los contrayentes se consideran unidos en legítimo matrimonio ante la sociedad y frente a las Leyes colombianas y aceptan cumplir fielmente los deberes y las obligaciones recíprocas que tal acto matrimonial trae consigo, respetándose los derechos naturales y civiles que cada uno tiene como persona humana, de conformidad con los preceptos establecidos en nuestras mencionadas leyes colombianas. La presente escritura de matrimonio fue leída personalmente por el(la) Suscrito(a) Notario(a) a los contrayentes, tal y conforme lo dispone la Ley, en clara y viva voz, la encontraron conforme a su voluntad, la aprobaron y la firman conmigo al(la) Suscrito(a) Notario(a) que de todo lo anterior doy fe. Los contrayentes presentaron los Siguientes documentos los cuales se protocolizan con el presente instrumento público: 1) Solicitud debidamente Autenticada para contraer matrimonio civil, 2) Fotocopias de las cédulas de ciudadanía de los contrayentes, 3) Fotocopias auténticas de los registros civiles de nacimiento de los contrayentes-----El presente matrimonio queda inscrito al indicativo serial número:\r\n " + indicativo_serial + ". --------- Así se firma en hojas de papel de seguridad notarial números: " + num_hojas1 + "- " + num_hojas2 + " -------------------------------------------------------------------------------------------\r\nDERECHOS: $" + derechos + " RECAUDOS $" + recaudo + " RESOLUCIÓN 00387 DE 23 DE ENERO DE 2023 DE LA SUPERINTENDENCIA DE NOTARIADO Y REGISTRO. IVA: $" + iva + " LEY 1819 DEL 29 DE DICIEMBRE DE 2016. RECEPCIONÓ: __________. ELABORÓ: " + elaboro + " FIRMAS: " + firmas + " CIERRE: _______. \"LO ESCRITO EN OTRO TIPO DE LETRA VALE\". ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\n\r\n\r\n\r\n_________________________________________\r\n" + nombre_otorgante1 + "\r\nC.C. " + cedula_otorgante1 + " EXPEDIDA EN " + ciud_exp_otorgante1 + ".\r\nOCUPACIÓN: \r\nDIRECCIÓN: \r\nTELÉFONOS: \r\nCORREO ELECTRÓNICO: \r\n\r\n\r\n\r\nLA CONTRAYENTE:\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n_________________________________________\r\n" + nombre_otorgante2 + "\r\nC.C. " + cedula_otorgante2 + " EXPEDIDA EN " + ciud_expd_otorgante2 + ".\r\nOCUPACIÓN: \r\nDIRECCIÓN: \r\nTELÉFONOS:\r\nCORREO ELECTRÓNICO: \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" + notario_encargado + "\r\nNOTARIO(A) SEGUNDO(A) DEL CÍRCULO DE MANIZALES\r\n\r\n\r\n\r\n";
                string minuta2 = "ESCRITURA PÚBLICA NÚMERO: Numero escritura en letras (Numero escritura en numero) \t\r\nFECHA DE OTORGAMIENTO: Fecha escritura formato largo mayuscul \t\r\nNOTARÍA DE ORIGEN:SEGUNDA (02) DEL CÍRCULO DE MANIZALES \t\r\nACTO JURÍDICO: MATRIMONIO CIVIL \t\r\nVALOR ACTO: SIN CUANTIA \t\r\nPERSONAS QUE INTERVIENEN EN EL ACTO \t\r\nEL CONTRAYENTE: \t\r\nContrayente 1 - Nombre completo Contrayente 1 - Tipo documento abreviaturaContrayente 1 - Numero documento con formato \t\r\nLA CONTRAYENTE:\t\r\nContrayente 2 - Nombre completo Contrayente 2 - Tipo documento abreviatura Contrayente 2 - Numero documento con formato \t\r\n \r\n\t\r\nESCRITURA PÚBLICA NÚMERO: Numero escritura en letras (Numero escritura en numero).\r\nEn el Municipio de Manizales, Círculo notarial del mismo nombre, Capital del Departamento de Caldas, República de Colombia, el día Fecha escritura formato largo mayuscul comparecieron Parrafo notario - Permisos y licencias\t\r\nLos señores  Contrayente 1 - Nombre completo, mayor de edad, vecino de Contrayente 1 - Municipio domicilio Titulo, identificado con Contrayente 1 - Tipo de documento nombre número Contrayente 1 - Numero documento con formato expedida Contrayente 1 - Lugar expedicion documento Mayuscula, nacido en Registro Civil De Nacimiento Contrayente 1 - Lugar de Nacimiento, el día  Registro Civil De Nacimiento Contrayente 1 - Fecha de Nacimiento, de nacionalidad Contrayente 1 - Nacionalidad y quien en la presente escritura se llamará EL CONTRAYENTE y Contrayente 2 - Nombre completo, mayor de edad, vecina de Contrayente 2 - Municipio domicilio Titulo, identificada con Contrayente 2 - Tipo de documento nombre númeroContrayente 2 - Numero documento con formato expedida en Contrayente 2 - Lugar expedicion documento Titulo, nacida en  Registro Civil De Nacimiento Contrayente 2 - Lugar de Nacimiento el día Registro Civil De Nacimiento Contrayente 2 - Fecha de Nacimiento, de nacionalidad  Contrayente 2 - Nacionalidad, y quien en la presente escritura se llamará LA CONTRAYENTE y dijeron:\t\r\n\t\r\n \r\n\r\n \r\n \r\nPRIMERO: Que en su entero y cabal juicio, es su deseo contraer matrimonio civil de conformidad con las prescripciones contenidas en el Decreto 2668 del 26 de Diciembre de 1.988. SEGUNDO: Que para tal efecto presentaron solicitud escrita y sus anexos, ante este despacho, todo lo cual se protocoliza con este instrumento público. TERCERO: Que constituidos en Audiencia Pública, el suscrito Notario preguntó claramente a los contrayentes si mediante el presente contrato de matrimonio, sin apremios de ninguna naturaleza, se quieren unir libre y espontáneamente, con el fin de formar una familia, vivir juntos, guardarse fe, socorrerse, procrear y ayudarse mutuamente en todas las circunstancias de la vida, con la afirmación de que el amor deberá presidir las relaciones entre los dos seres que por ministerio de la Ley quedan unidos en legítimo matrimonio ante la comunidad, procurando, con toda discreción y ternura, corregirse recíprocamente sus defectos, practicar la tolerancia y proceder en todos los casos con generosidad, equidad y templanza, evitando que entre ellos como esposos se presenten agravios de palabra o de obra que por su naturaleza irremediable comprometen la estabilidad del matrimonio, como comunión permanente entre dos seres que acuerdan transitar juntos el camino de la vida, como serían los hijos que llegaren a tener, preguntas y postulados anteriores todos los cuales los contrayentes, habiendo escuchado muy atentamente la lectura de esta escritura, manifiestan al suscrito Notario, con voz clara y perceptible que la han entendido completamente y por ello la aceptan y cumplirán íntegramente dichos postulados. - Agregan los contrayentes que el amor que los ha determinado para acogerse al vínculo matrimonial establecido por la Ley y por la sociedad civil para perpetuar la especie les servirá para que en el transcurso de su vida estimulen una aproximación cada vez más estrecha entre  ellos  como  marido  y  mujer, para  así  entregarse por  entero el uno al otro para la formación de la familia, con el pleno sentido de las responsabilidades que adquieren entre sí, para con sus descendientes y frente a la comunidad a la cual pertenecen. Cada cual aportará su contingente, según las necesidades de la familia, para constituirse en elementos de progreso ante la sociedad a la cual deberán entregar, en el futuro, hijos y ciudadanos formados y educados en una atmósfera propicia para ser útiles a la familia, a la sociedad y a la patria; procurarán, en todo momento, que lo que ambos desearon al unirse en matrimonio no vaya a desmentirse por duras que sean las circunstancias que se les presente en el transcurso de su vida matrimonial. CUARTO: Manifiestan los contrayentes al suscrito Notario que no tienen impedimento alguno para contraer matrimonio y que entre ellos no existe parentesco que pueda obstaculizarlo.  QUINTO: Que, en consecuencia, a partir de hoy los contrayentes se consideran unidos en legítimo matrimonio ante la sociedad y frente a las Leyes colombianas y aceptan cumplir fielmente los deberes y las obligaciones recíprocas que tal acto matrimonial trae consigo, respetándose los derechos naturales y civiles establecidos en nuestras mencionadas leyes colombianas. Parrafo alternativo - CON O SIN LEGITIMACIÓN N2 \r\n\t\r\n \r\n\r\n \r\n \r\nLos contrayentes presentaron los Siguientes documentos los cuales se protocolizan con el presente instrumento público: 1) Solicitud debidamente Autenticada para contraer matrimonio civil, 2) Copias de las cédulas de ciudadanía de los contrayentes, 3) Copias de los registros civiles de nacimiento de los contrayentes válidos para contraer matrimonio. \t\r\nEl presente matrimonio queda inscrito al indicativo serial número: PROTOCOLISTA INSERTE AQUÍ INDICATIVO SERIAL \t\r\nAsí se firma en los sellos de seguridad Notarial números: Hojas papel sellado utilizadas \t\r\n\t\r\nDERECHOS: $Valor derechos notariales con formato RECAUDOS $Valor Fondo con formato Y $Valor Super con formato Resolucion de tarifas en mayuscula DE LA SUPERINTENDENCIA DE NOTARIADO Y REGISTRO. IVA: $Valor IVA con formato  LEY 1819 DEL 29 DE DICIEMBRE DE 2016. . ELABORÓ: Iniciales funcionario que capturo datos. \"LO ESCRITO EN OTRO TIPO DE LETRA VALE\".\t\r\n \r\n \r\n \r\n \r\n  \r\nEL CONTRAYENTE,\r\n \r\n _______________________________\r\nContrayente 1 - Nombre completo   \r\nContrayente 1 - Tipo documento abreviatura NÚMERO Contrayente 1 - Numero documento con formato EXPEDIDA EN Contrayente 1 - Lugar expedicion documento Mayuscula \r\nDIRECCIÓN: El contrayente 1- Direccion  \r\nTELÉFONO: El contrayente 1- Telefono   \r\nCORREO ELECTRONICO: El contrayente 1 - Email  \r\nACTIVIDAD ECONOMICA: El contrayente 1- Actividad economica  \r\n \r\n \r\n \r\n \r\n \r\n  \r\nLA CONTRAYENTE,\r\n \r\n________________________________  \r\nContrayente 2 - Nombre completo   \r\nContrayente 2 - Tipo documento abreviatura NÚMERO Contrayente 2 - Numero documento con formato EXPEDIDA EN Contrayente 2 - Lugar expedicion documento Mayuscula \r\nDIRECCIÓN: El contrayente 2- Direccion \r\nTELÉFONO: El contrayente 2- Telefono  \r\nCORREO ELECTRONICO: El contrayente 2 - Email  \r\nACTIVIDAD ECONOMICA: El contrayente 2- Actividad economica  \r\n \r\n \r\n \r\n \r\n \r\n \r\n  Firma notario - Permisos y licencias  \r\n";
                richTextBox1.Rtf = @"{\rtf1\ansi\deff0" + minuta + "}";


            }
            catch (Exception)
            {
                MessageBox.Show("error en los datos");
                throw;
            }
        }



        static DateTime ObtenerFechaDesdeCadena(string cadenaFechaOriginal)
        {
            // Puedes ajustar el formato según la cadena de entrada real
            return DateTime.ParseExact(cadenaFechaOriginal, "dddd, dd 'DE' MMMM 'DE' yyyy", CultureInfo.GetCultureInfo("es-ES"));
        }

        static string FormatearFecha(DateTime fecha)
        {
            DateTime fechaSeleccionada = DateTime.Now;
            // Obtener componentes de la fecha
            string dia = fecha.ToString("dd"); // Día en formato de dos dígitos
            string mes = fecha.ToString("MMMM", CultureInfo.GetCultureInfo("es-ES")); // Nombre del mes en español
            string año = ConvertirNumeroAPalabras(fechaSeleccionada.Year); // Año en formato de cuatro dígitos

            // Convertir el número del día a palabras
            string diaEnPalabras = ObtenerNumeroEnPalabras(dia);

            // Crear la cadena de fecha en el nuevo formato
            string resultado = $"{diaEnPalabras} ({dia}) DE {mes.ToUpper()} DE {año.ToUpper()} ({fecha.Year})";

            return resultado;
        }
        static string ObtenerNumeroEnPalabras(string numero)
        {
            {
                string[] unidades = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE" };
                string[] especiales = { "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISÉIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE" };
                string[] decenas = { "CERO", "DIEZ", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };

                int num = int.Parse(numero);

                if (num < 10)
                {
                    return unidades[num];
                }
                else if (num < 20)
                {
                    return especiales[num - 10];
                }
                else
                {
                    int decena = num / 10;
                    int unidad = num % 10;

                    if (unidad == 0)
                    {
                        return decenas[decena];
                    }
                    else
                    {
                        return $"{decenas[decena]} Y {unidades[unidad]}";
                    }
                }
            }
        }
        static string ConvertirNumeroAPalabras(int numero)
        {
            return numero.ToWords();
        }
        public void GuardarComoWord(string contenido)
        {
            // Inicializa una aplicación Word
            Word.Application wordApp = new Word.Application();

            // Crea un nuevo documento de Word
            Word.Document doc = wordApp.Documents.Add();

            // Obtiene el formato actual del RichTextBox
            object oFalse = false; // Valor opcional para algunos parámetros
            object oTrue = true;
            object oUnit = Word.WdUnits.wdCharacter;
            object oCount = 1;
            object oExtend = Word.WdMovementType.wdExtend;

            // Copia el contenido del RichTextBox al documento de Word
            richTextBox1.SelectAll();
            richTextBox1.Copy();
            doc.ActiveWindow.Selection.Paste();

            // Guarda el documento en un archivo
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos de Word|.docx|Todos los archivos|.*";
            saveFileDialog1.Title = "Guardar como archivo de Word";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                doc.SaveAs2(filePath);
            }

            // Cierra la aplicación Word
            wordApp.Quit();
        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarComoWord(richTextBox1.Text);
        }

        private void btnatras_Click(object sender, EventArgs e)
        {

            Main form1 = new Main();

            this.Close();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnPegarDesdeWord_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string filePath = @"C:\Users\User\Desktop\Nueva carpeta\MINUTAS\CANCELACION DE HIPOTECA\Cancelación De Hipoteca Abierta Entre Particulares.docx";

                // Instancia de Word Application
                Word.Application wordApp = new Word.Application();
                    Word.Document doc = null;

                try
                {
                    // Abre el documento de Word
                    doc = wordApp.Documents.Open(filePath);

                    // Limpia el RichTextBox
                    richTextBox1.Clear();

                    // Itera sobre los párrafos y agrega el texto con formato al RichTextBox
                    foreach (Word.Paragraph paragraph in doc.Paragraphs)
                    {
                        richTextBox1.AppendText(paragraph.Range.Text + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                    {
                        MessageBox.Show($"Error al abrir el documento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Cierra Word Application y libera los recursos
                        doc?.Close();
                        wordApp?.Quit();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                    }
                }


            }
        }
    }///////cierra main

