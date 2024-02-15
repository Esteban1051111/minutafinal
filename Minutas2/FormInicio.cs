using DocumentFormat.OpenXml.Wordprocessing;
using Humanizer;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Word = Microsoft.Office.Interop.Word;

namespace Minutas2
{
    public partial class Main : Form
    {
        string filePath;
        public Main()
        {
            InitializeComponent();
          
            cmbMinutas.Items.Add("Poder general"); 
            cmbMinutas.Items.Add("Poder General Natural A Natural");
            cmbMinutas.Items.Add("Matrimonio civil");
            cmbMinutas.Items.Add("Venta de contado entre particulares");


            cmbMinutas.SelectedIndex = 0;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbMinutas.SelectedItem == null)
            {

                MessageBox.Show("Selecciona una minuta antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedForm = cmbMinutas.SelectedItem.ToString();


                switch (selectedForm)
                {
                    case "Matrimonio civil":
                        formMatrimonio_civil form4 = new formMatrimonio_civil();
                        string minutamatri1 = "ESCRITURA PÚBLICA NÚMERO: “+num_escritura+”-------------------------\r\nFECHA: “+fecha_otorgamiento+”-----\r\nCLASE DE ACTO: “+acto+”. ---------------------------------------------------------\r\nOTORGANTES: “+nombre_otorgante1+”, IDENTIFICADO CON LA CÉDULA DE CIUDADANÍA NÚMERO “+cedula_otorgante1+” EXPEDIDA EN “+ciud_exp_otorgante1+”, Y ”+nombre_otorgante2+”, IDENTIFICADA CON LA CÉDULA DE CIUDADANÍA NÚMERO “+cedula_otorgante2 +” EXPEDIDA EN \r\n”+ciud_expd_otorgante2+”. -------------------NOTARÍA DE ORIGEN: NOTARÍA SEGUNDA DE MANIZALES. -------------------------\r\nEn el municipio de Manizales, capital del departamento de Caldas, República de Colombia, al “+cadenaFechaFormateada +”, en el despacho de la NOTARIA SEGUNDA DEL CÍRCULO DE MANIZALES a cargo del Notario(a) “+titular+” “+notario_encargado +”, --------------------------------Comparecieron, el señor(a) “+nombre_otorgante1+”, mayor de edad, vecino de Manizales, identificado con la cédula de ciudadanía número “+cedula_otorgante1+” expedida en“+ciud_exp_otorgante1+”, nacido en \"+lugar_naci_otorgante1+”, el día “+fecha_naci_otorgante1+” de nacionalidad Colombiana y quien en la presente escritura se llamará EL CONTRAYENTE; y la señora ”+nombre_otorgante2+”,, mayor de edad, vecina de Manizales, identificada con la cédula de ciudadanía número “+cedula_otorgante2 +” expedida en ”+ciud_expd_otorgante2+”., nacida en \"+lugar_naci_otorgante2+”, el día “+fecha_naci_otorgante1+”, de nacionalidad Colombiana y quien en la presente escritura se llamará LA CONTRAYENTE; hábiles para contratar y obligarse, y dijeron: PRIMERO: Que en su entero y cabal juicio, es su deseo contraer matrimonio civil de conformidad con las prescripciones contenidas en el Decreto 2668 del 26 de Diciembre de 1.988. SEGUNDO: Que para tal efecto presentaron solicitud escrita y sus anexos, ante este despacho, todo lo cual se protocoliza con este instrumento público. TERCERO: Que constituidos en Audiencia Pública, el(la) Suscrito(a) Notario(a) preguntó claramente a los contrayentes si mediante el presente contrato de matrimonio, sin apremios de ninguna naturaleza, se quieren unir libre y espontáneamente, con el fin de formar una familia, vivir juntos, guardarse fe, socorrerse, procrear y ayudarse mutuamente en todas las circunstancias de la vida, con la afirmación de que el amor deberá presidir las relaciones entre los dos seres que por ministerio de la Ley quedan unidos en legítimo matrimonio ante la comunidad, procurando, con toda discreción y ternura, corregirse recíprocamente sus defectos, practicar la tolerancia y proceder en todos los casos con generosidad, equidad y templanza, evitando que entre ellos como esposos se presenten agravios de palabra o de obra que por su naturaleza irremediable comprometen la estabilidad del matrimonio, como comunión permanente entre dos seres que acuerdan transitar juntos el camino de la vida, como serían los hijos que llegaren a tener, preguntas y postulados anteriores todos los cuales los contrayentes, habiendo escuchado muy atentamente la lectura de esta escritura, manifiestan a el(la) Suscrito(a) Notario(a), con voz clara y perceptible que la han entendido completamente y por ello la aceptan y cumplirán íntegramente dichos postulados.- Agregan los contrayentes que el amor que los ha determinado para acogerse al vínculo matrimonial establecido por la Ley y por la  sociedad civil para perpetuar la especie les servirá para que en el transcurso de su vida estimulen una aproximación cada vez más estrecha entre  ellos  como  marido  y  mujer, para  así  entregarse por  entero  el  uno  al otro para la formación de la familia, con el pleno sentido de las responsabilidades que adquieren entre sí, para con sus  descendientes y frente a la comunidad a la cual pertenecen. Cada cual aportará su contingente, según las necesidades de la familia, para  constituirse en elementos de progreso ante la sociedad a la cual deberán  entregar, en el futuro, hijos y ciudadanos formados y educados en una atmósfera propicia para ser útiles a la familia, a la sociedad y a la patria; procurarán, en todo momento, que lo que ambos desearon al unirse en matrimonio no vaya a desmentirse  por  duras  que  sean  las  circunstancias que se les presente en el transcurso de su vida matrimonial.- CUARTO: Manifiestan los contrayentes al(la) Suscrito(a) Notario(a) que no tienen impedimento alguno para contraer matrimonio y que entre ellos no existe parentesco que pueda obstaculizarlo. – QUINTO: Que, en consecuencia, a partir de hoy los contrayentes se consideran unidos en legítimo matrimonio ante la sociedad y frente a las Leyes colombianas y aceptan cumplir fielmente los deberes y las obligaciones recíprocas que tal acto matrimonial trae consigo, respetándose los derechos naturales y civiles que cada uno tiene como persona humana, de conformidad con los preceptos establecidos en nuestras mencionadas leyes colombianas. La presente escritura de matrimonio fue leída personalmente por el(la) Suscrito(a) Notario(a) a los contrayentes, tal y conforme lo dispone la Ley, en clara y viva voz, la encontraron conforme a su voluntad, la aprobaron y la firman conmigo al(la) Suscrito(a) Notario(a) que de todo lo anterior doy fe. Los contrayentes presentaron los Siguientes documentos los cuales se protocolizan con el presente instrumento público: 1) Solicitud debidamente Autenticada para contraer matrimonio civil, 2) Fotocopias de las cédulas de ciudadanía de los contrayentes, 3) Fotocopias auténticas de los registros civiles de nacimiento de los contrayentes-----El presente matrimonio queda inscrito al indicativo serial número:\r\n”+ indicativo_serial+”. --------- Así se firma en hojas de papel de seguridad notarial números: “+num_hojas1+”- “num_hojas2” -------------------------------------------------------------------------------------------\r\nDERECHOS: $“+derechos+” RECAUDOS $“+recaudo+” RESOLUCIÓN 00387 DE 23 DE ENERO DE 2023 DE LA SUPERINTENDENCIA DE NOTARIADO Y REGISTRO. IVA: $”+iva+” LEY 1819 DEL 29 DE DICIEMBRE DE 2016. RECEPCIONÓ: __________. ELABORÓ: “+elaboro+” FIRMAS: ”+firmas+” CIERRE: _______. \"LO ESCRITO EN OTRO TIPO DE LETRA VALE\". ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n\r\n\r\n\r\n\r\n_________________________________________\r\n“+nombre_otorgante1+”\r\nC.C. “+cedula_otorgante1+” EXPEDIDA EN ”+ ciud_exp_otorgante1+”.\r\nOCUPACIÓN: \r\nDIRECCIÓN: \r\nTELÉFONOS: \r\nCORREO ELECTRÓNICO: \r\n\r\n\r\n\r\nLA CONTRAYENTE:\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n_________________________________________\r\n“+nombre_otorgante2+”\r\nC.C. “+cedula_otorgante2+” EXPEDIDA EN “+ciud_expd_otorgante2+”.\r\nOCUPACIÓN: \r\nDIRECCIÓN: \r\nTELÉFONOS:\r\nCORREO ELECTRÓNICO: \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n“+notario_encargado+”\r\nNOTARIO(A) SEGUNDO(A) DEL CÍRCULO DE MANIZALES\r\n\r\n\r\n\r\n";
                        form4.richTextBox1.ReadOnly = false;
                        form4.richTextBox1.Text= minutamatri1;
                        form4.richTextBox1.ReadOnly = true;
                        form4.Show();
                        break;

                    case "Poder general":
                        Formpoder_general form2 = new Formpoder_general();
                        string minuta = "ESCRITURA PÚBLICA NÚMERO: \r\n\r\nFECHA DE OTORGAMIENTO: SEIS (06) DE DICIEMBRE DE DOS MIL VEINTITRÉS (2023) \t\r\nNOTARÍA DE ORIGEN: SEGUNDA (02) DEL CÍRCULO DE MANIZALES \t\r\nACTO JURÍDICO: PODER GENERAL\t\r\nVALOR ACTO: SIN CUANTÍA\t\r\nPERSONAS QUE INTERVIENEN EN EL ACTO\t\r\nPARTE PODERDANTE \t\r\nDIANA PAOLA TORO VILLADA                   C.C. 24.343.577 \t\r\nPARTE APODERADA \t\r\nJORGE HERNAN RUBIO BETANCUR         C.C. 9.975.983 ---------------------------\r\nESCRITURA PÚBLICA NÚMERO: \r\n\r\nEn el Municipio de Manizales, Círculo notarial del mismo nombre, Capital del Departamento de Caldas, República de Colombia, a los SEIS (06) días de DICIEMBRE DE DOS MIL VEINTITRÉS (2023), comparecieron al despacho de la NOTARÍA SEGUNDA a cargo del Notario(a) Titular  JORGE MANRIQUE ANDRADE, la señora  DIANA PAOLA TORO VILLADA, de estado civil DIVORCIADA CON SOCIEDAD CONYUGAL DISUELTA Y LIQUIDADA, mayor de edad, vecina de Manizales, identificada con la Cédula de Ciudadanía número 24.343.577  expedida en Manizales, hábil para contratar y obligarse, quien obra en su propio nombre y representación y manifestó:\t- PRIMERO: Que, por medio de este instrumento público, confiero PODER GENERAL, AMPLIO Y SUFICIENTE, al(a) señor(a) JORGE HERNAN RUBIO BETANCUR, mayor de edad, vecino de Manizales, identificado con la Cédula de Ciudadanía número 9.975.983 expedida en Manizales, para que me represente en los siguientes actos y contratos relacionados con mis bienes, derechos y obligaciones a saber:\t -----------------------------------------------------------------------------------------------------  1) Para que administre(n) todos y cada uno de mis bienes, sean muebles o inmuebles, que se determinen en los títulos de propiedad del(los) exponente(s). 2) Para que recaude(n) mis productos y celebre los contratos que sean necesarios para la administración de dichos bienes. 3) Para que, judicial o extrajudicialmente, perciba(n) el valor de los créditos que se me adeudan, expida(n) los recibos y haga(n) las cancelaciones del caso. 4) Para que pague los créditos que adeudo y haga con los acreedores los arreglos y transacciones que estime convenientes. 5) Para que por cuenta de los créditos que se me adeuden admita de los deudores daciones en pago. 6) Para rematar bienes en juicio por mi cuenta. 7) Para solicitar, aprobar o improbar cuentas y recibir los saldos respectivos. 8) Para prometer en venta, vender, comprarse a sí mismo, permutar, enajenar en dación en pago, firmar cheques, pagares, letras de cambio y disponer de cualquier manera de los bienes muebles o inmuebles de mi propiedad, así como para adquirir bienes a cualquier título a mi favor. De igual forma, para que adquiera cualquier tipo de inmueble a mi nombre. 9) Para que garantice con hipoteca los créditos que se me adeuden y acepte en mi nombre las garantías hipotecarias. 10) Para que cancele las hipotecas constituidas a mi favor, reciba el dinero y suscriba las respectivas escrituras públicas de cancelación. 11) Para que grave con hipoteca los bienes inmuebles de mi propiedad o los bienes inmuebles que adquiera a mi nombre, con el fin de asegurar las obligaciones contraídas o que se contraigan en mi nombre, estipule tipo de interés, plazo y demás condiciones del crédito, así como firmar pagaré, carta de instrucciones y demás documentos requeridos por el acreedor. Mi(s) apoderado(s) queda ampliamente facultado para constituir hipoteca, a favor de cualquier entidad financiera que estime conveniente y/o solicite, de igual forma para llevar a cabo de inicio a fin todo lo concerniente con este mandato. 12) Para que asegure las obligaciones contraídas a mi nombre con prenda sobre mis bienes muebles. 13) Para que transija pleitos, deudas o diferencias que se presenten respecto de mis derechos y obligaciones. 14) Para que reciba y entregue dinero en calidad de mutuo o préstamo con hipoteca e interés por mi cuenta. 15) Para que constituya servidumbres activas o pasivas en favor o a cargo de los inmuebles de mi propiedad y los someta al régimen del Propiedad Horizontal, acogiéndose al ordenamiento jurídico correspondiente. 16) Para que gire, endose, acepte, afiance y/o proteste letras de cambio y para que gire y endose cheques, pagarés u otros instrumentos o títulos valores negociables a mi nombre. 17) Para que abra y mueva cuentas corrientes y ahorros, depósitos, pague créditos y todo tipo de productos bancarios, gire cheques, pagarés y libranzas en Bancolombia S.A., Banco Davivienda S.A., Banco Caja Social, Banco Agrario, Fondo Nacional del Ahorro, Banco BBVA, Bancos del Grupo Aval, Banco de Bogotá, Banco Popular, Cooperativas, Scotiabank Colpatria, Banco GNB Sudameris, Bancoomeva, Helm Bank, Banco Itaú, Banco Falabella y/o en cualquier entidad bancaria o financiera. 18) Para que me represente ante cualquier autoridad judicial, extrajudicial o administrativa en toda clase de juicios, actuaciones o diligencias como demandante o demandada o como coadyuvante de cualquiera de las partes, ya sea para iniciar o continuar hasta su terminación los juicios, actuaciones o diligencias respectivas. 19) Para que desista de tales juicios, actuaciones o diligencias judiciales o administrativas y de los incidentes que en ellos se propongan. 20) Para que sustituya este poder total o parcialmente y para que revoque tales poderes o sustituciones, para nombrar abogados que me representen en toda clase de trámites, actos administrativos, judiciales, civiles, penales, ante cualquier autoridad civil, personas naturales y/o jurídicas. 21) Para que a mi nombre constituya todo tipo de sociedades tales como colectivas, comanditas, limitadas, por acciones, comanditas simples, anónimas de cooperativas, asociaciones, sociedades anónimas, sociedad por acciones simplificada; intervengan en la elaboración de los estatutos siguiendo los lineamientos establecidos por las leyes colombianas; intervenga en la administración y orientación de tales empresas, ya sea  que se constituyan y/o que sea parte o llegare a serlo por cualquier medio; para que adquiera a cualquier título cuotas de interés social en todo tipo de sociedades e intervenga en las mismas; para que transfiera esas cuotas partes y en fin, para  que me represente en todo lo que se relacione con la constitución, reforma, disolución y liquidación de toda clase de sociedades y convenga, con los demás socios las cláusulas y compromisos que se deben establecer en los correspondientes estatutos. 22) Para que anualmente presente mis declaraciones de renta y patrimonio; pague los impuestos respectivos de orden municipal, nacional y los demás que se generen; solicite certificaciones ante la misma administración para los fines que considere convenientes; presente ante la administración de impuesto nacionales o ante el Tribunal Contencioso Administrativo respectivo, demandas sobre reclamaciones de impuestos y realice cualquier trámite ante la DIAN sin restricción alguna. 23) Para que constituya depósitos a término, recaude mis productos, los reinvierta, transfiera a otras entidades financieras o personas naturales; para administrar con amplias facultades y criterio los depósitos a término, en cuenta corriente o de ahorro que, en el momento de otorgar este poder general, posea o llegare a poseer o adquirir por cualquier medio, igualmente para que realice avances en efectivo de cualquier cuantía en todas las entidades financieras y para que maneje las tarjetas de crédito o débito que se encuentren a mi nombre en Bancolombia S.A., Banco Davivienda S.A., Banco Caja Social, Banco Agrario, Fondo Nacional del Ahorro, Banco BBVA, Bancos del Grupo Aval, Banco de Bogotá, Banco Popular, Cooperativas, Scotiabank Colpatria, Banco GNB Sudameris, Bancoomeva, Helm Bank, Banco Itaú, Banco  Falabella  y/o en cualquier  entidad bancaria o financiera. 24) Para que transfiera a título de dación en pago, permuta o venta los bienes, muebles o inmuebles de mi propiedad. 25) Para que dé a título de arrendamiento por escritura pública o por contrato privado los bienes muebles o inmuebles de mi propiedad; recaude mis productos o rentas, firme los contratos respectivos y proceda judicial o extrajudicialmente para su recuperación en caso de ser necesario. 26) Para aceptar herencias, legados o donaciones que se difieran a mi nombre, con o sin beneficio de inventario. Mi(s) apoderado(s)(a) también queda ampliamente facultado(a) para vender, donar o ceder los derechos herenciales, vinculados o universales, que me puedan corresponder dentro de alguna sucesión o herencia a favor de la persona que estime conveniente, incluso para sí misma y suscribir la escritura pública correspondiente. Así mismo, mi(s) apoderado(s)(a) queda ampliamente facultado(a) para suscribir la escritura pública de sucesión y realizar todos los trámites pertinentes, gestionar, presentar el trabajo de inventarios, avalúos, partición y/o adjudicación de bienes, interponer todos los recursos del caso en defensa de mis legítimos derechos e intereses, adquirir derechos herenciales, aclarar y resciliar, si es el caso, presentar la documentación requerida, sustituir parcial o totalmente el presente poder al abogado que estime conveniente para realizar todo lo concerniente al trámite de sucesión, si fuese necesario aportar comprobantes fiscales, solicitar información y realizar trámites ante entidades públicas y/o privadas, y en general todo lo concerniente con el mandato aquí conferido, y en fin, con tan amplias facultades, que en ningún momento se diga que carece de suficiente representación, para llevar a cabo esta gestión. 27) Para que por cuenta de los créditos reconocidos o que se reconozcan a mi favor, admita en pago bienes distintos de los que están obligados a dar mis deudores y para que remate tales bienes en juicio. 28) Para que condone total o parcialmente las deudas a mi favor y para que conceda a los deudores esperas para satisfacer sus obligaciones. 29) Para que ratifique ampliamente contratos de compraventa, de permuta, dación en pago de inmuebles celebrados por mí. 30) Para que haga donaciones entre vivos de bienes muebles o inmuebles de mi propiedad, presentes o futuros y para que obtenga las insinuaciones judiciales necesarias. 31) Para que nove mis obligaciones o las contraídas a mi favor. 32) Para que someta a la decisión de tribunales de arbitramiento, constituidos de acuerdo con la ley o con la costumbre, los pleitos, deudas o diferencias relativas a los derechos y obligaciones y para que me represente en la sustitución del juicio o de los juicios arbitrales respectivos. 33) Para que celebre a mi nombre contratos de sociedades o de cuentas en participación y aporte cualquier clase de bienes de mi propiedad. 34) Para que en los negocios que lo considere necesario o indispensable, haga de mi contraparte o contrate consigo mismo, en su propio nombre o como representante de un tercero. -35) Para que en fin, asuma la personería y mi representación, siempre que lo estime conveniente y necesario para mis intereses, de tal manera que en ningún momento ni en caso alguno quede sin representación de mis negocios o asuntos de interés y haga mis veces en ellos. 36) Para que abra cuentas corrientes, de ahorros, tarjetas de crédito, cancele las mismas, solicite chequera, reciba y proteste cheques, realice retiros en efectivo y/o cheque, solicite cualquier clase de información, y averigüe sobre dividendos en diferentes acciones que tenga con entidades bancarias y para que pueda realizar cualquier tipo de trámite sin restricción alguna con Bancolombia S.A., Banco Davivienda S.A., Banco Caja Social, Banco Agrario, Fondo Nacional del Ahorro, Banco BBVA, Bancos del Grupo Aval, Banco de Bogotá, Banco Popular, Cooperativas, Scotiabank Colpatria, Banco GNB Sudameris, Bancoomeva, Helm Bank, Banco Itaú, Banco  Falabella  y/o en cualquier  entidad bancaria o financiera. 37) Para que reclame y reciba el pago de indemnización laboral o cualquier otro concepto que se me reconozca; la pensión de jubilación que por vejez, invalidez o a cualquier otro título me llegare a ser reconocida por la Nación, COLPENSIONES, FOPEP, FOMAG u otra Autoridad Administrativa Pública, Privada o Tribunal de lo Contencioso Administrativo respectivo, como también para recibir en pago el valor de cada una de las mesadas correspondientes; liquidación laboral, liquidación total de mis cesantías y reliquidación pensional,  para que en caso de recibir cheques o cualquier otro título valor,  los pueda cambiar, cobrar o endosar si fuere el caso, para realizar cualquier tipo de trámite ante Fondos de pensiones y cesantías, realizar traslado de fondo de pensiones y/o cesantías a la entidad que estime conveniente. 38) En general, para que en mi nombre y representación y sin ninguna limitación o restricción, celebre y ejecute todos los actos administrativos y dispositivos que personalmente pudiera celebrar y ejecutar y, que, por la ley, no sean indelegables y para representarme, sin restricción alguna, ante cualquier autoridad, entidades, persona jurídica o natural, con facultades para ejecutar todos los actos como si actuara estando presente. 39) Para que de acuerdo con el procedimiento indicado en la Ley 258 de enero de 1996, emita las declaraciones que sean pertinentes, de acuerdo con mi estado civil existente en el momento de la realización del negocio que este celebrando y exprese categóricamente la verdadera situación jurídica del inmueble objeto del contrato, todo ajustado a la mencionada Ley 258, en cuanto a la facultad para comprometerlo también podrá el(os) mismo(s) apoderado(s) actuar sin límite. 40) Para que realice judicialmente o a través de notaría, todos los trámites de divorcio y liquidación de la sociedad conyugal, y/o anulación de matrimonio civil ante cualquier entidad civil y religiosa, lo cual incluye otorgar poder a otros abogados para presentar la solicitud de divorcio, aportar la documentación que le sea solicitada, firmar las escrituras públicas correspondientes, firmar trabajos de partición y adjudicación, comparecer ante la autoridad judicial correspondiente y, en general, todo lo que sea necesario para tal fin. 41) Para que, según el trámite establecido en la ley, constituya patrimonio de familia inembargable y/o afectación a vivienda familiar y para que igualmente proceda a su cancelación. 42) Para que pueda comprar, vender, pignorar, matricular, levantar prenda, firmar cualquier documento, comprar y firmar pólizas de vehículos contra terceros y representarme ante cualquier Oficina de Tránsito y Transporte y, en general, todos los trámites necesarios en relación con vehículos. 43) Para que firme declaraciones de cambio de divisas y negociar divisas a nombre del poderdante en Bancolombia S.A., Banco Davivienda S.A., Banco Caja Social, Banco Agrario, Fondo Nacional del Ahorro, Banco BBVA, Bancos del Grupo Aval, Banco de Bogotá, Banco Popular, Cooperativas, Scotiabank Colpatria, Banco GNB Sudameris, Bancoomeva, Helm Bank, Banco Itaú, Banco  Falabella  y/o en cualquier  entidad bancaria o financiera y todo lo concerniente con las mismas; adquirir y cancelar todo tipo de productos en entidades financieras, así como realizar retiros de dinero, consignaciones y, en general, todo tipo de transacciones ante cualquiera de las mismas. 44) Así mismo, para que bajo la gravedad de juramento emita las manifestaciones de ley necesarias para el cumplimiento a la ley 2010 del 27 de diciembre del 2019. 45) Para que constituya fiducia civil a mi nombre y/o cualquier otra persona natural o jurídica, sobre los bienes muebles o inmuebles que estén a mi nombre y para que igualmente proceda a su cancelación, firme escritura pública, firme documentos, solicite información y todo lo correspondiente a este acto. 46) Para que abra cualquier tipo de crédito y pueda realizar cualquier tipo de trámite sin restricción alguna, especialmente con el Banco de Bogotá, Banco Davivienda S.A y Banco BBVA y/o en cualquier entidad bancaria o financiera. --------------------------------------------------Aceptación: En estas condiciones comparece el señor JORGE HERNAN RUBIO BETANCUR, de las condiciones civiles anteriormente mencionadas, quien acepta el poder que mediante esta escritura se le otorga.\t\r\nLAS DECLARACIONES CONTENIDAS EN LA PRESENTE ESCRITURA FUERON REDACTADAS PERSONALMENTE POR LOS COMPARECIENTES, QUIENES LAS PRESENTARON EN FORMA ESCRITA AL SUSCRITO NOTARIO. ---------------- NOTA IMPORTANTE: LA PRESENTE ESCRITURA PÚBLICA FUE LEÍDA EN SU TOTALIDAD POR LOS COMPARECIENTES Y LA ENCONTRARON CONFORME A SU PENSAMIENTO, VOLUNTAD Y POR NO OBSERVAR ERROR ALGUNO EN SU CONTENIDO, LE IMPARTEN SU APROBACIÓN Y PROCEDEN A FIRMARLA CON EL SUSCRITO NOTARIO QUE DA FE. DECLARANDO IGUALMENTE LOS COMPARECIENTES ESTAR NOTIFICADOS DE QUE UN ERROR NO CORREGIDO EN ESTA ESCRITURA DESPUÉS DE SER FIRMADA CON RESPECTO A SU NOMBRE E IDENTIFICACIÓN, DA LUGAR A UNA ESCRITURA ACLARATORIA QUE CONLLEVA A NUEVOS GASTOS PARA LOS CONTRATANTES, CONFORME LO ESTIPULA EL ARTICULO 102 DEL DECRETO LEY 960 DE 1.970, DE TODO LO CUAL QUEDAN POR ENTENDIDOS Y FIRMAN EN CONSTANCIA. LEÍDO EL PRESENTE INSTRUMENTO POR LOS COMPARECIENTES, LO ENCONTRARON CORRIENTE Y FIRMAN CON EL SUSCRITO NOTARIO QUE AUTORIZA ESTE ACTO. \t\r\nAsí se firma en los sellos de seguridad Notarial números: --\r\n\r\nDERECHOS: $74.900 RECAUDOS $ 15.900. RESOLUCION 00387 DEL 23 DE ENERO DE 2023 DE LA SUPERINTENDENCIA DE NOTARIADO Y REGISTRO. IVA: $ 26.125. LEY 1819 DEL 29 DE DICIEMBRE DE 2016. ELABORÓ: FERNANDA \"LO ESCRITO EN OTRO TIPO DE LETRA VALE\". \t\r\n \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n_____________________________________\r\nDIANA PAOLA TORO VILLADA \r\nC.C. 24.343.577 EXPEDIDA EN MANIZALES\r\nDIRECCIÓN: \r\nTELÉFONO: \r\nOCUPACIÓN: \r\nCORREO: \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n_____________________________________\r\nJORGE HERNAN RUBIO BETANCUR  \r\nC.C. 9.975.983 EXPEDIDA EN MANIZALES\r\nDIRECCIÓN: \r\nTELÉFONO: \r\nOCUPACIÓN: \r\nCORREO: \r\n\r\n";
                        form2.richTextBox1.ReadOnly = false;
                        form2.richTextBox1.Text = minuta;
                        
                        form2.richTextBox1.ReadOnly = true;

                        form2.Show();
                        break;
                    case "Poder General Natural A Natural":


                        Pg_abogado PoderGNN = new Pg_abogado();
                        Parametrizar_minuta editor = new Parametrizar_minuta();
                        filePath = @"C:\Users\User\Desktop\Nueva carpeta\MINUTAS\PODERES\Poder General Natural A Natural.docx";
                        
                        string minutaPoderGNN = ObtenerTextoDesdeWord(filePath);

                        abrir_editortexto(PoderGNN.paneleditortexto, new Parametrizar_minuta(), minutaPoderGNN);
                        PoderGNN.Show();
                       
                      
                        
                        break;

                    case "Venta de contado entre particulares":
                           VentaContadoParticulares vent = new VentaContadoParticulares();
                             Parametrizar_minuta min = new Parametrizar_minuta();
                         filePath = @"C:\Users\User\Desktop\Nueva carpeta\MINUTAS\VENTAS\Venta De Contado Entre Particulares.docx";
                        string minutaVCP=ObtenerTextoDesdeWord(filePath);

                        abrir_editortexto(vent.paneleditordetexto, new Parametrizar_minuta(),minutaVCP);
                       

                            vent.Show();
                       




                        break;
                    default:
                        break;

                }// cierra case

            }// cierra else





        }//cierra metodo principañ
        private string ObtenerTextoDesdeWord(string filePath)
        {
            try
            {
                Word.Application wordApp = new Word.Application();
                Word.Document doc = wordApp.Documents.Open(filePath);

                // Seleccionar todo el contenido y copiar el formato de la selección
                string wordtext = doc.Content.Text;
             
                doc.Close();
              

                return wordtext;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el documento de Word: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }


        private void btnNueva_minuta_Click(object sender, EventArgs e)
        {
            login login = new login();  
            login.Show();
        }


        private void abrir_editortexto(Panel editor, Parametrizar_minuta formulario1, string textoInicial)
        {
            formulario1.TopLevel = false;
            formulario1.FormBorderStyle = FormBorderStyle.None;
            formulario1.Dock = DockStyle.Fill;

            // Asigna el texto al RichTextBox en el formulario Parametrizar_minuta
            formulario1.SetTextoEnRichTextBox(textoInicial);

            editor.Controls.Add(formulario1);
            editor.Tag = formulario1;
            formulario1.BringToFront();
            formulario1.Show();
        }


    }
}