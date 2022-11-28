﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Algoritmos
{
    internal class Llenado
    {
        //Atributos
        private int cifra;
        private string msj, msj2, msj3;

        //Constructor
        public Llenado(int cifra)
        {
            this.cifra = cifra;
        }

        public void setCifra(int cifra)
        {
            this.cifra = cifra;
        }

        public int getCifra()
        {
            return cifra;
        }

        public string mostrarMensaje()
        {
            return msj;
        }
        public string mostrarMensaje2()
        {
            return msj2;
        }
        public string mostrarMensaje3()
        {
            return msj3;
        }

        public void escogerCarrera(int area)
        {
            if (area == 0)//CIENCIAS
            {
                switch (cifra)
                {
                    case 0:
                        //Perfil biologia
                        string Aa1 = "Tiene conocimientos básicos a un nivel medio superior en las áreas de las ciencias naturales.\r\n";
                        string Aa2 = "Es creativo e innovador en el estudio de procesos y técnicas biológicas.";
                        string Aa3 = "Tiene habilidades, destrezas y actitudes para la investigación en el campo de las ciencias biológicas.";
                        string Aa4 = "Tiene disponibilidad para el trabajo en equipo mostrando principios y valores éticos.";
                        string Aa5 = "Es observador, proactivo y con capacidad de liderazgo para fomentar el cuidado del ambiente, salud pública y agroindustria.";
                        string Aa6 = "Muestra compromiso e identificación con la universidad, sociedad y ambiente.";

                        //comp biologia
                        string Aa7 = "Evalúa sistemas biológicos y su entorno, aplicando técnicas de análisis clínicos, biológicos, epidemiológicos y forenses, en la determinación de metabolitos, identificación celular, de agentes etiológicos,\r\n vectores en enfermedades metaxénicas, evidencias biológicas en la escena del crimen, de acuerdo con marcos teóricos, avances científicos, política nacional de salud y nuevo código \r\n procesal penal, con actitud ética.";
                        string Aa8 = "Promueve la conservación del medio ambiente y la biodiversidad según marcos teóricos actuales que le permite proponer acciones de desarrollo sostenible y bienestar de la comunidad, en el marco de la \r\n normativa nacional e internacional, mostrando una actitud de respeto al ser humano y su entorno.";
                        string Aa9 = "Gestiona procesos de producción acuícola y agroindustrial, de acuerdo con marcos teóricos interdisciplinarios que contribuyen al desarrollo del sector y responden a la demanda del mercado nacional e \r\n internacional, según normas de calidad sanitaria e inocuidad, con eficacia, eficiencia, actitud ética y responsabilidad social.";
                        string Aa10 = "Gestionar proyectos de investigación, emprendimiento e innovación tecnológica en las áreas de salud, conservación, acuícola y agroindustrial, respondiendo a la demanda del mercado nacional e \r\n internacional, según marcos teóricos interdisciplinarios y avances científicos, con responsabilidad social.";

                        //datos biologia
                        string Aa11 = "GRADO ACADÉMICO: Bachiller en Ciencias Biológicas";
                        string Aa12 = "TÍTULO PROFESIONAL: Biólogo";
                        string Aa13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Aa1 + "\r\n" + Aa2 + "\r\n" + Aa3 + "\r\n" + Aa4 + "\r\n" + Aa5 + "\r\n" + Aa6;
                        this.msj2 = Aa7 + "\r\n" + Aa8 + "\r\n" + Aa9 + "\r\n" + Aa10;
                        this.msj3 = Aa11 + "\r\n" + Aa12 + "\r\n" + Aa13;
                        break;
                    case 1:
                        //perfil enfermeria
                        string Ab1 = "Capacidad de lectura rápida, comprensión lectora y redacción.";
                        string Ab2 = "Condiciones para trabajar en equipo, ser solidario, respetuoso capaz de demostrar empatía en sus relaciones interpersonales.";
                        string Ab3 = "Sentido de servicio que contribuya al cuidado de la persona, familia, comunidad y el medio ambiente.";
                        string Ab4 = "Convicción de que la carrera de enfermería eseminentemente vocacional, humanística y de servicio a los demás.";
                        string Ab5 = "Conocimientos básicos de ética, valores y ciencias básicas aplicadas relacionadas con la carrera profesional.";

                        //comp enfermeria
                        string Ab7 = "Desarrolla los cuidados de enfermería considerando las bases teóricas y conceptuales según guías de salud, lineamientos y de acuerdo a las normas vigentes.";
                        string Ab8 = "Desarrolla el plan de cuidado de enfermería a la persona sana o enferma en cada curso de vida según protocolos, guías de salud y norma vigente, investigando problemas de salud recurrentes.";
                        string Ab9 = "Desarrolla proyectos de investigación y procesos de gestión de instituciones de salud asegurando brindar cuidados de enfermería en los tres niveles de atencióne acuerdo a la norma vigente.";
                        string Ab10 = "Desarrolla acciones y planes de intervenciones de enfermería en promoción, prevención, recuperación y rehabilitación en la persona, familia  y comunidad según la norma vigente en el primer \r\n nivel de atención de salud.";

                        //datos enfermeria
                        string Ab11 = "GRADO ACADÉMICO: Bachiller en Enfermeria";
                        string Ab12 = "TÍTULO PROFESIONAL: Licenciado en Enfermeria";
                        string Ab13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ab1 + "\r\n" + Ab2 + "\r\n" + Ab3 + "\r\n" + Ab4 + "\r\n" + Ab5;
                        this.msj2 = Ab7 + "\r\n" + Ab8 + "\r\n" + Ab9 + "\r\n" + Ab10;
                        this.msj3 = Ab11 + "\r\n" + Ab12 + "\r\n" + Ab13;
                        break;
                    case 2:
                        //perfil farmacia y bioquimica
                        string Ac1 = "El ingresante al programa académico de Farmacia y Bioquímica debe tener conocimientos básicos a un nivel medio superior en el área de ciencias(Matemática, Biología, Física y Química).";
                        string Ac2 = "Convicción de que la carrera del Profesional Químico Farmacéutico es eminentemente dinámica, creativa, innovadora, humanística, con valores éticos y deontológicos y con vocación de \r\n servicio a los demás.";
                        string Ac3 = "Capacidad cognoscitiva y psicomotriz con disposición para el auto aprendizaje, especialmente en el área de ciencias químicas y biológicas en interés de la salud y cuidado del medio \r\n ambiente.";

                        //comp farmacia y bioquimica
                        string Ac7 = "Analiza productos farmacéuticos y cosméticos de acuerdo a las Buenas Prácticas de Laboratorio.";
                        string Ac8 = "Gestiona la producción de fitofármacos y homeopáticos de calidad según normas vigentes.";
                        string Ac9 = "Analiza alimentos, productos sanitarios de salud, dispositivos médicos y otras sustancias o productos de acuerdo a las Buenas Prácticas de Laboratorio.";
                        string Ac10 = "Gestiona los productos farmacéuticos, cosméticos, dispositivos médicos y productos sanitarios según procedimientos, normativas, avances tecnológicos y principios farmacotécnicos.";

                        //datos farmacia y bioquimica
                        string Ac11 = "GRADO ACADÉMICO: Bachiller en Farmacia y Bioquimica";
                        string Ac12 = "TÍTULO PROFESIONAL: Químico farmacéutico";
                        string Ac13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ac1 + "\r\n" + Ac2 + "\r\n" + Ac3;
                        this.msj2 = Ac7 + "\r\n" + Ac8 + "\r\n" + Ac9 + "\r\n" + Ac10;
                        this.msj3 = Ac11 + "\r\n" + Ac12 + "\r\n" + Ac13;
                        break;
                    case 3:
                        //perfil veterinaria y zootecnia
                        string Ad1 = "Tiene vocación para la carrera profesional de Medicina Veterinaria y Zootecnia.";
                        string Ad2 = "Tiene conocimientos generales de las ciencias básicas.";
                        string Ad3 = "Demuestra capacidad de comunicación oral y escrita en idioma español.";
                        string Ad4 = "Tiene dominio básico de la tecnología de información y comunicación.";
                        string Ad5 = "Demuestra capacidad de trabajo en equipo y adecuada interacción social y ética.";
                        string Ad6 = "Capacidad reflexiva y de análisis de los problemas relacionados a la salud animal, producción animal y salud pública veterinaria.";

                        //comp veterinaria y zootecnia
                        string Ad7 = "NO ESPECIFICADAS";

                        //datos veterinaria y zootecnia
                        string Ad11 = "GRADO ACADÉMICO: Bachiller en Ciencias veterinarias";
                        string Ad12 = "TÍTULO PROFESIONAL: Médico veterinario zootecnista";
                        string Ad13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ad1 + "\r\n" + Ad2 + "\r\n" + Ad3 + "\r\n" + Ad4 + "\r\n" + Ad5 + "\r\n" + Ad6;
                        this.msj2 = Ad7;
                        this.msj3 = Ad11 + "\r\n" + Ad12 + "\r\n" + Ad13;
                        break;

                    case 4:
                        //perfil obstetricia
                        string Ae1 = "Evidencia identidad personal, social y respeto por los derechos de las personas y el medio ambiente.";
                        string Ae2 = "Muestra una actitud y motivación necesaria para el estudio de nivel universitario.";
                        string Ae3 = "Asume principios éticos y morales para desenvolverse en la universidad y vivir en sociedad.";
                        string Ae4 = "Utiliza las TIC en su desarrollo personal y académico con sentido crítico y productivo.";
                        string Ae5 = "Gestiona su aprendizaje de manera autónoma.";
                        string Ae6 = "Comprende la información obtenida de las diferentes fuentes de información.";

                        //comp obstetricia
                        string Ae7 = "Elabora proyectos de investigación en salud y toma decisiones utilizando información pertinente.";
                        string Ae8 = "Desarrolla procesos de gestión de instituciones de salud para la elaboración y ejecución del Plan Operativo Institucional.";
                        string Ae9 = "Atiende integralmente la salud sexual reproductiva de la mujer, con la participación activa de la pareja, familia y comunidad demostrando actitud ética, respetando sus derechos y \r\n factores interculturales, de acuerdo a procedimientos y normativa según nivel de salud.";
                        string Ae10 = "Desarrolla acciones de promoción y prevención de la salud sexual reproductiva de la persona, familia y comunidad de manera integral, aplicando modelos de salud que fomenten el \r\n Auto cuidado de los estilos de vida y entornos saludables, haciendo uso de la tecnología y de acuerdo a la normativa vigente.";

                        //datos obstetricia
                        string Ae11 = "GRADO ACADÉMICO: Bachiller en Obstetricia";
                        string Ae12 = "TÍTULO PROFESIONAL: Licenciado en Obstetricia";
                        string Ae13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ae1 + "\r\n" + Ae2 + "\r\n" + Ae3 + "\r\n" + Ae4 + "\r\n" + Ae5 + "\r\n" + Ae6;
                        this.msj2 = Ae7 + "\r\n" + Ae8 + "\r\n" + Ae9 + "\r\n" + Ae10;
                        this.msj3 = Ae11 + "\r\n" + Ae12 + "\r\n" + Ae13;
                        break;
                    case 5:
                        //perfil odontologia
                        string Af1 = "Indaga utilizando conocimientos básicos sobre procedimientos de investigación científica para mejorar la calidad de vida de su comunidad.";
                        string Af2 = "Gestiona su aprendizaje de manera autónoma. ";
                        string Af3 = "Posee conocimientos básicos en química, matemática, anatomía y biología.";
                        string Af4 = "Hace uso de las tecnologías de la información para gestionar su comunicación y aprendizaje.";
                        string Af5 = "Comprende textos orales y escritos realizando un adecuado raciocinio y juicio crítico en base a lectura de textos. ";
                        string Af6 = "Se comunica en su lengua materna demostrando una adecuada expresión oral y redacción de textos escritos. ";

                        //comp odontologia
                        string Af7 = "Diagnostica el estado de la salud bucodental de la persona en base a la evaluación realizada utilizando métodos, técnicas y protocolos establecidos, según las bases teóricas \r\n científicas del cuerpo humano.";
                        string Af8 = "Desarrolla proyectos de investigación, solucionando y mejorando la salud bucal de la población con conducta ética y científica.";
                        string Af9 = "Brinda tratamientos integrales y de urgencia de salud bucal en niños y adultos, utilizando equipos e instrumentos según metodologías específicas y especializadas con \r\n eficiencia, eficacia centrado en el bienestar del paciente.";
                        string Af10 = "Brinda tratamientos rehabilitadores de salud bucal a las personas, utilizando equipos e instrumentos tecnológicos actualizados según bases teóricas científicas y \r\n metodologías específicas y especializadas con eficiencia, eficacia centrado en el bienestar del paciente.";

                        //datos odontologia
                        string Af11 = "GRADO ACADÉMICO: Bachiller en Odontologia";
                        string Af12 = "TÍTULO PROFESIONAL: Cirujano dentista";
                        string Af13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Af1 + "\r\n" + Af2 + "\r\n" + Af3 + "\r\n" + Af4 + "\r\n" + Af5 + "\r\n" + Af6;
                        this.msj2 = Af7 + "\r\n" + Af8 + "\r\n" + Af9 + "\r\n" + Af10;
                        this.msj3 = Af11 + "\r\n" + Af12 + "\r\n" + Af13;
                        break;
                    case 6:
                        //perfil psicologia
                        string Ag1 = "Capacidad de abstracción, análisis y síntesis.";
                        string Ag2 = "Habilidades comunicativas verbales y escritas.";
                        string Ag3 = "Actitud positiva y gran capacidad de adaptación.";
                        string Ag4 = "Vocación por la carrera profesional.";
                        string Ag5 = "Pensamiento creativo, lógico, crítico y analítico.";
                        string Ag6 = "Conocimiento básico conceptual de la psicología, filosofía, educación cívica.";

                        //comp psicologia
                        string Ag7 = "Realiza la evaluación diagnóstica de problemas psicopedagógicos y psicopatológicos de la persona, mediante técnicas e instrumentos específicos, desde los enfoques \r\n y corrientes psicológicas, aplicando metodologías y protocolos vigentes.";
                        string Ag8 = "Evalúa con ética a la persona o grupo humano en sus contextos de interacción, que le permita definir el diagnóstico psicológico de la salud mental y emocional desde \r\n los marcos conceptuales de las teorías psicológicas, aplicando metodologías y normativa vigente.";
                        string Ag9 = "Desarrolla proyectos de investigación científica sobre el comportamiento humano en relación con su contexto, aplicando técnicas, normas y estándares establecidos y \r\n difunde sus resultados.";

                        //datos psicologia
                        string Ag11 = "GRADO ACADÉMICO: Bachiller en Psicología";
                        string Ag12 = "TÍTULO PROFESIONAL: Psicólogo";
                        string Ag13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ag1 + "\r\n" + Ag2 + "\r\n" + Ag3 + "\r\n" + Ag4 + "\r\n" + Ag5 + "\r\n" + Ag6;
                        this.msj2 = Ag7 + "\r\n" + Ag8 + "\r\n" + Ag9;
                        this.msj3 = Ag11 + "\r\n" + Ag12 + "\r\n" + Ag13;
                        break;
                }
            }
            if (area == 1)
            {
                switch (cifra)//HUMANIDADES
                {
                    case 0:
                        //perfil administracion
                        string Ba1 = "Sentido de responsabilidad y compromiso laboral.";
                        string Ba2 = "Aptitudes para el trabajo interdisciplinario.";
                        string Ba3 = "Habilidades básicas para la investigación científica.";
                        string Ba4 = "Habilidades de Comunicación.";
                        string Ba5 = "Conocimientos fundamentales relacionados a la Carrera Profesional de Administración.";
                        string Ba6 = "Conocimientos fundamentales en matemática, lenguaje, realidad nacional y mundial etc.";

                        //comp administracion
                        string Ba7 = "Evalúa planes Estratégicos, según los elementos y categorías de la planeación administrativa.";
                        string Ba8 = "Diseña estructura, cargos, procesos y procedimientos, de acuerdo a los documentos de gestión.";
                        string Ba9 = "Dirige al potencial humano y las organizaciones, de acuerdo a los objetivos organizacionales y normas vigentes.";
                        string Ba10 = "Desarrolla medidas de mejoramiento continuo y proyectos de investigación, de acuerdo a normas e indicadores de gestión de la calidad.";

                        //datos administracion
                        string Ba11 = "GRADO ACADÉMICO: Bachiller en Administración";
                        string Ba12 = "TÍTULO PROFESIONAL: Licenciado en Administración";
                        string Ba13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ba1 + "\r\n" + Ba2 + "\r\n" + Ba3 + "\r\n" + Ba4 + "\r\n" + Ba5 + "\r\n" + Ba6;
                        this.msj2 = Ba7 + "\r\n" + Ba8 + "\r\n" + Ba9 + "\r\n" + Ba10;
                        this.msj3 = Ba11 + "\r\n" + Ba12 + "\r\n" + Ba13;
                        break;
                    case 1:
                        //perfil arqueologia
                        string Bb1 = "Comprende los procesos históricos y sociales de nuestro país y del mundo.";
                        string Bb2 = "Desarrolla procesos autónomos de aprendizaje en forma permanente y durante toda la vida.";
                        string Bb3 = "Comprende la contribución del patrimonio cultural en el arte y se apropian de él para realizar producciones creativas individuales y colectivas.";
                        string Bb4 = "Asume la interculturalidad, la equidad de género y la inclusión como formas de convivencia para un enriquecimiento y aprendizaje mutuo.";

                        //comp arqueologia
                        string Bb7 = "Argumenta construcciones teóricas teniendo en cuenta procesos culturales, métodos y técnicas de análisis con criticidad y en el marco de la normatividad \r\n vigente.";
                        string Bb8 = "Gestiona el valor del uso social del patrimonio arqueológico involucrando a la comunidad circundante.";
                        string Bb9 = "Gestiona proyectos de puesta en valor de sitios arqueológicos, integrándose a equipos multidisciplinarios, para el uso social en el marco de las normas y \r\n políticas culturales. ";
                        string Bb10 = "Elabora proyectos de investigación y gestión del patrimonio arqueológico integrándose a equipos multidisciplinarios y en el marco de la normatividad \r\n vigente.";

                        //datos arqueologia
                        string Bb11 = "GRADO ACADÉMICO: Bachiller en Arqueología";
                        string Bb12 = "TÍTULO PROFESIONAL: Licenciado en Arqueología";
                        string Bb13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bb1 + "\r\n" + Bb2 + "\r\n" + Bb3 + "\r\n" + Bb4;
                        this.msj2 = Bb7 + "\r\n" + Bb8 + "\r\n" + Bb9 + "\r\n" + Bb10;
                        this.msj3 = Bb11 + "\r\n" + Bb12 + "\r\n" + Bb13;
                        break;
                    case 2:
                        //perfil cs comunicacion
                        string Bc1 = "Iniciativa y curiosidad por el ámbito profesional.";
                        string Bc2 = "Posee vocación para la comunicación y la información.";
                        string Bc3 = "Comprende los procesos históricos y sociales de nuestro país y del mundo.";
                        string Bc4 = "Evidencia habilidades blandas, comunicativas y capacidad de comprender los mensajes en los distintos lenguajes de la comunicación.";
                        string Bc5 = "Asume la interculturalidad, la equidad de género y la inclusión como formas de convivencia para un enriquecimiento y aprendizaje mutuo.";
                        string Bc6 = "Hace uso responsable de las tecnologías de la información y de la comunicación (TIC) para interactuar con la información, gestionar su comunicación \r\n y aprendizaje.";

                        //comp cs comunicacion
                        string Bc7 = "Evalúa la gestión por resultados, según metodología establecida.";
                        string Bc8 = "Desarrolla productos comunicativos multifuncionales de acuerdo a las estructuras, a la investigación y a la normatividad vigente.";
                        string Bc9 = "Argumenta procesos comunicativos en las relaciones y comportamientos de las instituciones públicas y privadas de acuerdo a la investigación, los \r\n contextos y teorías comunicacionales.";
                        string Bc10 = "Gestiona acciones comunicacionales, relaciones interinstitucionales, con los medios de comunicación y actores sociales considerando la \r\n investigación y la normatividad vigente.";

                        //datos cs comunicacion
                        string Bc11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la comunicación";
                        string Bc12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de la comunicación";
                        string Bc13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bc1 + "\r\n" + Bc2 + "\r\n" + Bc3 + "\r\n" + Bc4 + "\r\n" + Bc5 + "\r\n" + Bc6;
                        this.msj2 = Bc7 + "\r\n" + Bc8 + "\r\n" + Bc9 + "\r\n" + Bc10;
                        this.msj3 = Bc11 + "\r\n" + Bc12 + "\r\n" + Bc13;
                        break;
                    case 3:
                        //perfil cs ed biologia y quimica
                        string Bd1 = "Tiene sólidos valores morales, actitudes positivas y conductas responsables.";
                        string Bd2 = "Comprende el entorno físico y tiene una actitud responsable con el medio ambiente.";
                        string Bd3 = "Utiliza las TIC, para la comunicación y el desarrollo del conocimiento.";
                        string Bd4 = "Analiza y comprende información oral y escrita, de acuerdo a las exigencias de la formación profesional.";
                        string Bd5 = "Respeta su realidad socio-cultural, participa e interactúa de manera democrática e inclusiva, considerando las opiniones de los demás y asumiendo \r\n plenamente su ciudadanía.";
                        string Bd6 = "Posee conocimientos previos y asume su propio aprendizaje para desarrollar nuevos saberes con iniciativa e interés permanente, que le permiten \r\n fortalecer su identidad y desarrollo personal. ";

                        //comp cs ed biologia y quimica
                        string Bd7 = "Planifica los procesos de enseñanza y aprendizaje basados en los lineamientos pedagógicos - curriculares y normas vigentes.";
                        string Bd8 = "Produce diversos documentos de gestión para la Institución Educativa, basados en el trabajo colaborativo, la participación ciudadana, evaluación continua \r\n y los lineamientos establecidos.";
                        string Bd9 = "Conduce procesos de enseñanza y aprendizaje basados en la contextualización, clima afectivo, dominio disciplinar, desarrollo del pensamiento crítico y \r\n complejo, ritmos y estilos de aprendizaje de los estudiantes, recursos y tecnologías pertinentes.";
                        string Bd10 = "Gestiona su formación continua para el fortalecimiento de su identidad y profesionalidad docente; así como para la elaboración de proyectos de investigación \r\n e innovación pedagógica, teniendo en cuenta su participación ciudadana, reflexión desde sus prácticas pre profesionales, y metodología.";

                        //datos cs ed biologia y quimica
                        string Bd11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la educación";
                        string Bd12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de educación con mención en ciencias Biológicas y Químicas";
                        string Bd13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bd1 + "\r\n" + Bd2 + "\r\n" + Bd3 + "\r\n" + Bd4 + "\r\n" + Bd5 + "\r\n" + Bd6;
                        this.msj2 = Bd7 + "\r\n" + Bd8 + "\r\n" + Bd9 + "\r\n" + Bd10;
                        this.msj3 = Bd11 + "\r\n" + Bd12 + "\r\n" + Bd13;
                        break;
                    case 4:
                        //perfil cs ed artistica
                        string Be1 = "Tiene sólidos valores morales, actitudes positivas y conductas responsables.";
                        string Be2 = "Comprende el entorno físico y tiene una actitud responsable con el medio ambiente.";
                        string Be3 = "Utiliza las TIC, para la comunicación y el desarrollo del conocimiento.";
                        string Be4 = "Analiza y comprende información oral y escrita, de acuerdo a las exigencias de la formación profesional.";

                        //comp cs ed artistica
                        string Be7 = "Planifica los procesos de enseñanza y aprendizaje basados en los lineamientos pedagógicos curriculares y normas vigentes.";
                        string Be8 = "Produce diversos documentos de gestión para la Institución Educativa, basados en el trabajo colaborativo, la participación ciudadana, evaluación continua y \r\n los lineamientos establecidos.";
                        string Be9 = "Conduce procesos de enseñanza y aprendizaje basados en la contextualización, clima afectivo, dominio disciplinar, desarrollo del pensamiento crítico y \r\n complejo, ritmos y estilos de aprendizaje de los estudiantes, recursos y tecnologías pertinentes.";

                        //datos cs ed artistica
                        string Be11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la educación";
                        string Be12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de educación con mención en educación artística";
                        string Be13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Be1 + "\r\n" + Be2 + "\r\n" + Be3 + "\r\n" + Be4;
                        this.msj2 = Be7 + "\r\n" + Be8 + "\r\n" + Be9;
                        this.msj3 = Be11 + "\r\n" + Be12 + "\r\n" + Be13;
                        break;
                    case 5:
                        //perfil cs ed educacion fisica
                        string Bf1 = "Tiene sólidos valores morales, actitudes positivas y conductas responsables.";
                        string Bf2 = "Comprende el entorno físico y tiene una actitud responsable con el medio ambiente.";
                        string Bf3 = "Utiliza las TIC, para la comunicación y el desarrollo del conocimiento.";
                        string Bf4 = "Tiene capacidad de razonamiento matemático, lógico y abstracto, para asumir nuevos conocimientos que le permitan adaptarse y enfrentar problemas en \r\n contextos reales.";
                        string Bf5 = "Respeta su realidad socio-cultural, participa e interactúa de manera democrática e inclusiva, considerando las opiniones de los demás y asumiendo \r\n plenamente su ciudadanía.";

                        //comp cs ed educacion fisica
                        string Bf7 = "Produce diversos documentos de gestión para la Institución Educativa, basados en el trabajo colaborativo, la participación ciudadana, evaluación continua \r\n y los lineamientos establecidos.";
                        string Bf8 = "Planifica los procesos de enseñanza y aprendizaje basados en los lineamientos pedagógicos curriculares y normas vigentes.";
                        string Bf9 = "Conduce procesos de enseñanza y aprendizaje basados en la contextualización, clima afectivo, dominio disciplinar, desarrollo del pensamiento crítico \r\n y complejo, ritmos y estilos de aprendizaje de los estudiantes, recursos y tecnologías pertinentes";

                        //datos cs ed educacion fisica
                        string Bf11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la educación";
                        string Bf12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de educación con mención en educación fisica";
                        string Bf13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bf1 + "\r\n" + Bf2 + "\r\n" + Bf3 + "\r\n" + Bf4 + "\r\n" + Bf5;
                        this.msj2 = Bf7 + "\r\n" + Bf8 + "\r\n" + Bf9;
                        this.msj3 = Bf11 + "\r\n" + Bf12 + "\r\n" + Bf13;
                        break;
                    case 6:
                        //perfil cs ed inicial
                        string Bg1 = "Tiene sólidos valores morales, actitudes positivas y conductas responsables.";
                        string Bg2 = "Comprende el entorno físico y tiene una actitud responsable con el medio ambiente.";
                        string Bg3 = "Utiliza las TIC, para la comunicación y el desarrollo del conocimiento.";
                        string Bg4 = "Analiza y comprende información oral y escrita, de acuerdo a las exigencias de la formación profesional.";

                        //comp cs ed inicial
                        string Bg7 = "Produce diversos documentos de gestión para la Institución Educativa, basados en el trabajo colaborativo, la participación ciudadana, evaluación \r\n continua y los lineamientos establecidos.";
                        string Bg8 = "Planifica los procesos de enseñanza y aprendizaje basados en los lineamientos pedagógicos curriculares y normas vigentes.";
                        string Bg9 = "Conduce procesos de enseñanza y aprendizaje basados en la contextualización, clima afectivo, dominio disciplinar, desarrollo del pensamiento crítico \r\n y complejo, ritmos y estilos de aprendizaje de los estudiantes, recursos y tecnologías pertinentes";

                        //datos cs ed inicial
                        string Bg11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la educación";
                        string Bg12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de educación con mención en educación inicial";
                        string Bg13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bg1 + "\r\n" + Bg2 + "\r\n" + Bg3 + "\r\n" + Bg4;
                        this.msj2 = Bg7 + "\r\n" + Bg8 + "\r\n" + Bg9;
                        this.msj3 = Bg11 + "\r\n" + Bg12 + "\r\n" + Bg13;
                        break;
                    case 7:
                        //perfil cs ed primaria
                        string Bh1 = "Analiza y comprende información oral y escrita, de acuerdo a las exigencias de la formación profesional.";
                        string Bh2 = "Comprende el entorno físico y tiene una actitud responsable con el medio ambiente.";
                        string Bh3 = "Utiliza las TIC, para la comunicación y el desarrollo del conocimiento.";
                        string Bh4 = "Analiza y comprende información oral y escrita, de acuerdo a las exigencias de la formación profesional.";

                        //comp cs ed primaria
                        string Bh7 = "Produce diversos documentos de gestión para la Institución Educativa, basados en el trabajo colaborativo, la participación ciudadana, evaluación \r\n continua y los lineamientos establecidos.";
                        string Bh8 = "Planifica los procesos de enseñanza y aprendizaje basados en los lineamientos pedagógicos curriculares y normas vigentes.";
                        string Bh9 = "Conduce procesos de enseñanza y aprendizaje basados en la contextualización, clima afectivo, dominio disciplinar, desarrollo del pensamiento crítico \r\n y complejo, ritmos y estilos de aprendizaje de los estudiantes, recursos y tecnologías pertinentes";

                        //datos cs ed primaria
                        string Bh11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la educación";
                        string Bh12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de educación con mención en educación primaria";
                        string Bh13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bh1 + "\r\n" + Bh2 + "\r\n" + Bh3 + "\r\n" + Bh4;
                        this.msj2 = Bh7 + "\r\n" + Bh8 + "\r\n" + Bh9;
                        this.msj3 = Bh11 + "\r\n" + Bh12 + "\r\n" + Bh13;
                        break;
                    case 8:
                        //perfil filosofia
                        string Bi1 = "Tiene sólidos valores morales, actitudes positivas y conductas responsables.";
                        string Bi2 = "Comprende el entorno físico y tiene una actitud responsable con el medio ambiente.";
                        string Bi3 = "Utiliza las TIC, para la comunicación y el desarrollo del conocimiento.";
                        string Bi4 = "Tiene capacidad de razonamiento matemático, lógico y abstracto, para asumir nuevos conocimientos que le permitan adaptarse y enfrentar problemas en \r\n contextos reales.";

                        //comp filosofia
                        string Bi7 = "Planifica los procesos de enseñanza y aprendizaje basados en los lineamientos pedagógicos curriculares y normas vigentes.";
                        string Bi8 = "Produce diversos documentos de gestión para la Institución Educativa, basados en el trabajo colaborativo, la participación ciudadana, evaluación \r\n continua y los lineamientos establecidos.";
                        string Bi9 = "Conduce procesos de enseñanza y aprendizaje basados en la contextualización, clima afectivo, dominio disciplinar, desarrollo del pensamiento \r\n crítico y complejo, ritmos y estilos de aprendizaje de los estudiantes, recursos y tecnologías pertinentes.";

                        //datos filosofia
                        string Bi11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la educación";
                        string Bi12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de educación con mención en filosofía, psicología y ciencias sociales";
                        string Bi13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bi1 + "\r\n" + Bi2 + "\r\n" + Bi3 + "\r\n" + Bi4;
                        this.msj2 = Bi7 + "\r\n" + Bi8 + "\r\n" + Bi9;
                        this.msj3 = Bi11 + "\r\n" + Bi12 + "\r\n" + Bi13;
                        break;
                    case 9:
                        //perfil historia y geo
                        string Bj1 = "Analiza y comprende información oral y escrita, de acuerdo a las exigencias de la formación profesional.";
                        string Bj2 = "Comprende el entorno físico y tiene una actitud responsable con el medio ambiente.";
                        string Bj3 = "Tiene sólidos valores morales, actitudes positivas y conductas responsables.";
                        string Bj4 = "Utiliza las TIC, para la comunicación y el desarrollo del conocimiento";

                        //comp historia y geo
                        string Bj7 = "Produce diversos documentos de gestión para la Institución Educativa, basados en el trabajo colaborativo, la participación ciudadana, evaluación \r\n continua y los lineamientos establecidos.";
                        string Bj8 = "Planifica los procesos de enseñanza y aprendizaje basados en los lineamientos pedagógicos curriculares y normas vigentes.";
                        string Bj9 = "Conduce procesos de enseñanza y aprendizaje basados en la contextualización, clima afectivo, dominio disciplinar, desarrollo del pensamiento crítico \r\n y complejo, ritmos y estilos de aprendizaje de los estudiantes, recursos y tecnologías pertinentes";

                        //datos historia y geo
                        string Bj11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la educación";
                        string Bj12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de educación con mención en Historia y geografía";
                        string Bj13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bj1 + "\r\n" + Bj2 + "\r\n" + Bj3 + "\r\n" + Bj4;
                        this.msj2 = Bj7 + "\r\n" + Bj8 + "\r\n" + Bj9;
                        this.msj3 = Bj11 + "\r\n" + Bj12 + "\r\n" + Bj13;
                        break;
                    case 10:
                        //perfil lengua y lit
                        string Bk1 = "Tiene sólidos valores morales, actitudes positivas y conductas responsables.";
                        string Bk2 = "Comprende el entorno físico y tiene una actitud responsable con el medio ambiente.";
                        string Bk3 = "Utiliza las TIC, para la comunicación y el desarrollo del conocimiento.";
                        string Bk4 = "Respeta su realidad socio-cultural, participa e interactúa de manera democrática e inclusiva, considerando las opiniones de los demás y asumiendo \r\n plenamente su ciudadanía.";

                        //comp lengua y lit
                        string Bk7 = "Planifica los procesos de enseñanza y aprendizaje basados en los lineamientos pedagógicos curriculares y normas vigentes.";
                        string Bk8 = "Produce diversos documentos de gestión para la Institución Educativa, basados en el trabajo colaborativo, la participación ciudadana, evaluación \r\n continua y los lineamientos establecidos.";
                        string Bk9 = "Conduce procesos de enseñanza y aprendizaje basados en la contextualización, clima afectivo, dominio disciplinar, desarrollo del pensamiento \r\n crítico y complejo, ritmos y estilos de aprendizaje de los estudiantes, recursos y tecnologías pertinentes.";


                        //datos lengua y lit
                        string Bk11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la educación";
                        string Bk12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de educación con mención en lenguaje y literatura";
                        string Bk13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bk1 + "\r\n" + Bk2 + "\r\n" + Bk3 + "\r\n" + Bk4;
                        this.msj2 = Bk7 + "\r\n" + Bk8 + "\r\n" + Bk9;
                        this.msj3 = Bk11 + "\r\n" + Bk12 + "\r\n" + Bk13;
                        break;
                    case 11:
                        //perf ed matematica e info
                        string Bl1 = "Comprende el entorno físico y tiene una actitud responsable con el medio ambiente.";
                        string Bl2 = "Utiliza las TIC, para la comunicación y el desarrollo del conocimiento.";
                        string Bl3 = "Analiza y comprende información oral y escrita, de acuerdo a las exigencias de la formación profesional.";
                        string Bl4 = "Respeta su realidad socio-cultural, participa e interactúa de manera democrática e inclusiva, considerando las opiniones de los demás y \r\n asumiendo plenamente su ciudadanía.";

                        //comp ed matematica e inf
                        string Bl7 = "Produce diversos documentos de gestión para la Institución Educativa, basados en el trabajo colaborativo, la participación ciudadana, \r\n evaluación continua y los lineamientos establecidos.";
                        string Bl8 = "Planifica los procesos de enseñanza y aprendizaje basados en los lineamientos pedagógicos curriculares y normas vigentes.";
                        string Bl9 = "Conduce procesos de enseñanza y aprendizaje basados en la contextualización, clima afectivo, dominio disciplinar, desarrollo del \r\n pensamiento crítico y complejo, ritmos y estilos de aprendizaje de los estudiantes, recursos y tecnologías pertinentes.";

                        //datos ed matematica e inf
                        string Bl11 = "GRADO ACADÉMICO: Bachiller en Ciencias de la educación";
                        string Bl12 = "TÍTULO PROFESIONAL: Licenciado en Ciencias de educación con mención en matemática e informatica";
                        string Bl13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bl1 + "\r\n" + Bl2 + "\r\n" + Bl3 + "\r\n" + Bl4;
                        this.msj2 = Bl7 + "\r\n" + Bl8 + "\r\n" + Bl9;
                        this.msj3 = Bl11 + "\r\n" + Bl12 + "\r\n" + Bl13;
                        break;
                    case 12:
                        //perfil contabilidad
                        string Bm1 = "Iniciativa y curiosidad por el ámbito profesional.";
                        string Bm2 = "Interés por las actividades económicas y empresariales.";
                        string Bm3 = "Evidencia habilidades blandas, comunicativas en forma oral y escrita.";
                        string Bm4 = "Comprende los procesos históricos y sociales de nuestro país y del mundo.";

                        //comp contabilidad
                        string Bm7 = "Establece el programa de auditoría y peritaje según el sector de acuerdo con las normas legales vigentes.";
                        string Bm8 = "Desarrolla los presupuestos y costos de acuerdo con las políticas empresariales y normas gubernamentales, agropecuarias, mineras \r\n y pesqueras.";
                        string Bm9 = "Establece el cumplimiento de las obligaciones tributarias en beneficio del estado por rentas y comercio externo de acuerdo con el \r\n marco normativo vigente.";

                        //datos contabilidad
                        string Bm11 = "GRADO ACADÉMICO: Bachiller en Contabilidad";
                        string Bm12 = "TÍTULO PROFESIONAL: Contador público";
                        string Bm13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bm1 + "\r\n" + Bm2 + "\r\n" + Bm3 + "\r\n" + Bm4;
                        this.msj2 = Bm7 + "\r\n" + Bm8 + "\r\n" + Bm9;
                        this.msj3 = Bm11 + "\r\n" + Bm12 + "\r\n" + Bm13;
                        break;
                    case 13:
                        //perfil derecho
                        string Bn1 = "Cumple con sus deberes oportunamente.";
                        string Bn2 = "Es defensor objetivo de sus derechos";
                        string Bn3 = "Demuestra habilidades comunicativas.";
                        string Bn4 = "Capacidad de análisis y síntesis.";
                        string Bn5 = "Habilidades para producción de textos.";
                        string Bn6 = "Conocimientos geográficos, históricos del Perú.";

                        //comp derecho
                        string Bn7 = "Gestiona aspectos vinculados al Estado de Derecho para personas naturales y jurídicas mediante la aplicación de técnicas de \r\n solución de controversias y el marco normativo de gobernanza.";
                        string Bn8 = "Brinda asistencia legal a personas naturales y personas jurídicas en las distintas especialidades del Derecho Privado, teniendo \r\n en cuenta el marco legal vigente.";
                        string Bn9 = "Asesora en la solución de controversias en las materias del Derecho Público, de acuerdo a los requerimientos de los usuarios, \r\n normas vigentes y los aportes de los métodos de investigación.";

                        //datos derecho
                        string Bn11 = "GRADO ACADÉMICO: Bachiller en derecho";
                        string Bn12 = "TÍTULO PROFESIONAL: Abogado";
                        string Bn13 = "DURACIÓN DE ESTUDIOS: 6 años y 12 semestres";

                        this.msj = Bn1 + "\r\n" + Bn2 + "\r\n" + Bn3 + "\r\n" + Bn4 + "\r\n" + Bn5 + "\r\n" + Bn6;
                        this.msj2 = Bn7 + "\r\n" + Bn8 + "\r\n" + Bn9;
                        this.msj3 = Bn11 + "\r\n" + Bn12 + "\r\n" + Bn13;
                        break;
                    case 14:
                        //perfil economia
                        string Bo1 = "Expresa libremente sus ideas y conocimientos previos sobre materias relacionadas a modelos matemáticos, comunicativos y \r\n sociales.";
                        string Bo2 = "Comprende la importancia de ser ciudadano y como en ello contribuye al desarrollo económico de nuestro país.";
                        string Bo3 = "Aplica procesos propios de aprendizaje para la obtención de conocimiento básicos para el desarrollo de su carrera \r\n universitaria en el ámbito social, político, económico y tecnológico.";
                        string Bo4 = "Conoce la realidad y evalúa las decisiones a partir de conocimientos previos en base a la situación problemática \r\n de nuestro país.";

                        //comp economia
                        string Bo7 = "Diseña estrategias financieras de acuerdo con las características del mercado financiero y políticas monetarias.";
                        string Bo8 = "Realiza el planeamiento del desarrollo económico de acuerdo con la política económica y políticas nacionales.";
                        string Bo9 = "Propone alternativas de optimización de actividades económicas de los agentes económicos, basadas en condiciones \r\n del mercado y los principios de la microeconomía.";

                        //datos economia
                        string Bo11 = "GRADO ACADÉMICO: Bachiller en Economia";
                        string Bo12 = "TÍTULO PROFESIONAL: Economista";
                        string Bo13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bo1 + "\r\n" + Bo2 + "\r\n" + Bo3 + "\r\n" + Bo4;
                        this.msj2 = Bo7 + "\r\n" + Bo8 + "\r\n" + Bo9;
                        this.msj3 = Bo11 + "\r\n" + Bo12 + "\r\n" + Bo13;
                        break;
                    case 15:
                        //perfil neg int
                        string Bp1 = "Realiza un desenvolvimiento en sus expresiones comunicativas y culturales que están sujetas a la interacción con \r\n la sociedad.";
                        string Bp2 = "Aplica responsablemente la utilización de las tecnologías de la información y de la comunicación (TIC) en la \r\n interacción en el mundo globalizado.";
                        string Bp3 = "Utiliza procesos de aprendizaje para la obtención de conocimientos para el desarrollo de su carrera universitaria \r\n en los ámbitos socioeconómicos, culturales, políticos y ambientales.";
                        string Bp4 = "Analiza la situación problemática de nuestro país con la finalidad de comprender los paradigmas en la gestión de las \r\n empresas públicas y privadas.";

                        //comp neg int
                        string Bp7 = "Plantear alternativas de inversión utilizando herramientas financieras, económicas y contables para su aplicación a \r\n proyectos internacionales.";
                        string Bp8 = "Evalúa estrategias comerciales de importación, exportación de las empresas y análisis matemático acorde con la \r\n biodiversidad existente, mediante la redacción de documentos de gestión de los negocios.";
                        string Bp9 = "Plantea propuestas de mercado, teniendo en cuenta la identificación de oportunidades de negocios internacionales \r\n mediante la aplicación de instrumentos de investigación.";

                        //datos neg int
                        string Bp11 = "GRADO ACADÉMICO: Bachiller en Negocios internacionales";
                        string Bp12 = "TÍTULO PROFESIONAL: Licenciado en Negocios internacionales";
                        string Bp13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bp1 + "\r\n" + Bp2 + "\r\n" + Bp3 + "\r\n" + Bp4;
                        this.msj2 = Bp7 + "\r\n" + Bp8 + "\r\n" + Bp9;
                        this.msj3 = Bp11 + "\r\n" + Bp12 + "\r\n" + Bp13;
                        break;
                    case 16:
                        //perfil turismo
                        string Bq1 = "Iniciativa y curiosidad por el ámbito profesional.";
                        string Bq2 = "Comprensión lectora.";
                        string Bq3 = "Compromiso de responsabilidad social y ambiental.";
                        string Bq4 = "Cuenta con aprendizajes previos de los procesos históricos y sociales de nuestro país y del mundo.";

                        //comp turismo
                        string Bq7 = "Gestiona los productos y destinos turísticos sostenibles según el marco regulatorio.";
                        string Bq8 = "Gestiona los servicios turísticos según la tendencia de mercado actual y normativa vigente.";
                        string Bq9 = "Desarrolla planes y proyectos turísticos según lineamientos de investigación y política de estado.";

                        //datos turismo
                        string Bq11 = "GRADO ACADÉMICO: Bachiller en Turismo";
                        string Bq12 = "TÍTULO PROFESIONAL: Licenciado en Turismo";
                        string Bq13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Bq1 + "\r\n" + Bq2 + "\r\n" + Bq3 + "\r\n" + Bq4;
                        this.msj2 = Bq7 + "\r\n" + Bq8 + "\r\n" + Bq9;
                        this.msj3 = Bq11 + "\r\n" + Bq12 + "\r\n" + Bq13;
                        break;

                }
            }
            if (area == 2)//INGENIERAS
            {
                switch (cifra)
                {
                    case 0:
                        //perfil agronomia
                        string Ca1 = "Tener conocimientos básicos en el agroecosistema y la necesidad de conservar el medio ambiente.";
                        string Ca2 = "Tener dominio básico de informática";
                        string Ca3 = "Tener conocimientos elementales de las ciencias básicas, buena redacción y ortografía.";
                        string Ca4 = "Tener autoestima y practica de valores de respeto, responsabilidad y puntualidad.";

                        //comp agronomia
                        string Ca7 = "Gestiona los procesos de sanidad y mejora vegetal en la producción de manera eficiente, considerando la \r\n sostenibilidad agrícola.";
                        string Ca8 = "Gestiona procesos productivos combinando y movilizando recursos, a través de técnicas e instrumentos con \r\n tecnología innovadoras de manera eficiente, en el marco de una agricultura sostenible.";
                        string Ca9 = "Gestiona recursos en los procesos productivos a través de técnicas e instrumentos con tecnología innovadoras \r\n de manera eficiente, en el marco de una agricultura sostenible.";

                        //datos agronomia
                        string Ca11 = "GRADO ACADÉMICO: Bachiller en Ciencias Agrícolas";
                        string Ca12 = "TÍTULO PROFESIONAL: Ingeniero Agrónomo";
                        string Ca13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ca1 + "\r\n" + Ca2 + "\r\n" + Ca3 + "\r\n" + Ca4;
                        this.msj2 = Ca7 + "\r\n" + Ca8 + "\r\n" + Ca9;
                        this.msj3 = Ca11 + "\r\n" + Ca12 + "\r\n" + Ca13;
                        break;
                    case 1:
                        //per arquitectura
                        string Cb1 = "Conocimientos matemáticos para entender el mundo que los rodea, resolver problemas y tomar decisiones \r\n útiles al entorno.";
                        string Cb2 = "Interés por las humanidades e historia, así como la contribución del patrimonio cultural en el arte y \r\n la identidad del ingresante.";
                        string Cb3 = "Uso del lenguaje de manera asertiva, propositiva, ética y responsable para comunicarse en diversas situaciones \r\n y comprender distintos tipos de textos orales y escritos.";
                        string Cb4 = "Comprensión del mundo físico que lo rodea en diálogo con los saberes locales, que le permitan asimilar el \r\n entorno natural, los modos de vida, aspectos socio económicos y culturales, sostenibles y responsables con el ambiente.";

                        //comp arquitectura
                        string Cb7 = "Diseña proyectos Arquitectónicos de nivel básico (pequeño nivel de complejidad), respondiendo a las \r\n necesidades locales en el marco del Reglamento Nacional de Edificaciones (RNE) con ética, creatividad e innovación.";
                        string Cb8 = "Diseña proyectos arquitectónicos y urbanos de mediana complejidad, así como el planeamiento de ciudades en el marco \r\n de la normatividad vigente, del trabajo colaborativo multi disciplinario desarrollando el ejercicio de la arquitectura a nivel técnico.";
                        string Cb9 = "Gestiona proyectos arquitectónicos y obras, así como de planeamiento urbano, incorporando la Gestión del Riesgo de \r\n Desastres (GRD) y la investigación en las áreas del ejercicio profesional de la arquitectura, en el marco de la normatividad vigente.";

                        //datos arquitectura
                        string Cb11 = "GRADO ACADÉMICO: Bachiller en Arquitectura";
                        string Cb12 = "TÍTULO PROFESIONAL: Arquitecto";
                        string Cb13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Cb1 + "\r\n" + Cb2 + "\r\n" + Cb3 + "\r\n" + Cb4;
                        this.msj2 = Cb7 + "\r\n" + Cb8 + "\r\n" + Cb9;
                        this.msj3 = Cb11 + "\r\n" + Cb12 + "\r\n" + Cb13;
                        break;
                    case 2:

                        //per estadistica
                        string Cc1 = "Tener conocimientos básicos y habilidades en matemática y estadística.";
                        string Cc2 = "Trabajar en equipo demostrando interés por la experimentación.";
                        string Cc3 = "Poseer valores, como sentido de responsabilidad e interés de superación profesional.";
                        string Cc4 = "Demostrar interés por la ciencia. Capacidad de observación y análisis, facilidad de expresar sus ideas.";

                        //comp estadistica
                        string Cc7 = "Construye modelos estadísticos para su aplicación en el análisis de datos en el ámbito de estudio e investigación \r\n utilizando software especializado, demostrando responsabilidad en el desempeño profesional.";
                        string Cc8 = "Emplea la Teoría de las probabilidades y las TICs para la ejecución de un plan de acción que facilite una adecuada \r\n toma de decisiones.";
                        string Cc9 = "Propone métodos y técnicas estadísticas para la aplicación de actividades en la investigación científica y en la \r\n didáctica, que contribuyan al acervo cognitivo de las ciencias.";

                        //datos estadistica
                        string Cc11 = "GRADO ACADÉMICO: Bachiller de Ciencias en Estadisticas";
                        string Cc12 = "TÍTULO PROFESIONAL: Estadistico";
                        string Cc13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Cc1 + "\r\n" + Cc2 + "\r\n" + Cc3 + "\r\n" + Cc4;
                        this.msj2 = Cc7 + "\r\n" + Cc8 + "\r\n" + Cc9;
                        this.msj3 = Cc11 + "\r\n" + Cc12 + "\r\n" + Cc13;
                        break;
                    case 3:
                        //per fisica
                        string Cd1 = "Conocimientos básicos del idioma inglés y de tecnología informática.";
                        string Cd2 = "Conocimientos en las Ciencias Básicas (Matemática, Física y Química), así como una amplia cultura.";
                        string Cd3 = "Valores éticos y morales como la honestidad,responsabilidad, respeto y tolerancia con las personas y comprometidos \r\n en el logro de una realidad cada vez más justa y afirmando su identidad.";
                        string Cd4 = "Amplia responsabilidad con el medio ambiente en cualquier actividad que desarrolle. Desarrolla su proceso de \r\n aprendizaje de manera continua y autónoma tanto individual, como grupalmente.";

                        //comp fisica
                        string Cd7 = "Planifica aplicaciones de la Física del Estado Sólido en el estudio de los minerales, de acuerdo a las normas \r\n establecidas.";
                        string Cd8 = "Implementa aplicaciones de la física nuclear y la biofísica para el tratamiento de la salud, de acuerdo a normas \r\n establecidas.";
                        string Cd9 = "Desarrolla estudios de las energías renovables para su aprovechamiento en el marco del desarrollo sostenible.";

                        //datos fisica
                        string Cd11 = "GRADO ACADÉMICO: Bachiller de Ciencias Físicas";
                        string Cd12 = "TÍTULO PROFESIONAL: Físico";
                        string Cd13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Cd1 + "\r\n" + Cd2 + "\r\n" + Cd3 + "\r\n" + Cd4;
                        this.msj2 = Cd7 + "\r\n" + Cd8 + "\r\n" + Cd9;
                        this.msj3 = Cd11 + "\r\n" + Cd12 + "\r\n" + Cd13;
                        break;
                    case 4:
                        //per ing ambiental
                        string Ce1 = "Interés por las interacciones del ser humano con su ambiente.";
                        string Ce2 = "Poseer un amplio interés por el campo de la investigación científica y tecnológica.";
                        string Ce3 = "Capacidad creativa, analítica y de liderazgo para la solución de problemas ambientales.";
                        string Ce4 = "Conocimientos básicos de programas virtuales, para el manejo de información de textos, revistas científicas, etc.";

                        //comp ing ambiental
                        string Ce7 = "Diseña procesos físicos, químicos, biológicos y de tecnologías limpias mitigando los efectos de las actividades \r\n industriales y de servicios en el marco del desarrollo sostenible.";
                        string Ce8 = "Formula proyectos de inversión de sistemas de abastecimiento de agua potable, alcantarillado, aguas residuales y residuos \r\n sólidos en el marco de la legislación ambiental.";
                        string Ce9 = "Evalúa los sistemas de gestión ambiental y sanitaria según la normatividad vigente en el marco de un trabajo \r\n colaborativo de acuerdo al sector.";

                        //datos ing ambiental
                        string Ce11 = "GRADO ACADÉMICO: Bachiller en Ingenieria ambiental y sanitaria";
                        string Ce12 = "TÍTULO PROFESIONAL:Ingeniero ambiental y sanitario";
                        string Ce13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ce1 + "\r\n" + Ce2 + "\r\n" + Ce3 + "\r\n" + Ce4;
                        this.msj2 = Ce7 + "\r\n" + Ce8 + "\r\n" + Ce9;
                        this.msj3 = Ce11 + "\r\n" + Ce12 + "\r\n" + Ce13;
                        break;
                    case 5:
                        //per ing civil
                        string Cf1 = "Manejo básico de recursos informáticos.";
                        string Cf2 = "Respeto a la sociedad y así mismo.";
                        string Cf3 = "Decidido y comprometido con la Responsabilidad Social al desarrollo social y el respeto al medio ambiente";
                        string Cf4 = "Solucionar problemas matemáticos básicos, concordante con el razonamiento lógico.";

                        //comp ing civil
                        string Cf7 = "Planifica proyectos de ingeniería de acuerdo a las etapas propias de la actividad profesional respetando las \r\n normativas nacionales e internacionales.";
                        string Cf8 = "Propicia la investigación científica aplicando instrumentos científicos y tecnológicos para la innovación de los \r\n procesos constructivos, de acuerdo a las normas técnicas y principios éticos.";
                        string Cf9 = "Implementa proyectos de ingeniería aplicando gestión prospectiva en el marco de la gestión de riesgo, del medio \r\n ambiente, adaptación al cambio climático y desarrollo sostenible.";

                        //datos ing civil
                        string Cf11 = "GRADO ACADÉMICO: Bachiller en Ingenieria Civil";
                        string Cf12 = "TÍTULO PROFESIONAL:Ingeniero Civil";
                        string Cf13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Cf1 + "\r\n" + Cf2 + "\r\n" + Cf3 + "\r\n" + Cf4;
                        this.msj2 = Cf7 + "\r\n" + Cf8 + "\r\n" + Cf9;
                        this.msj3 = Cf11 + "\r\n" + Cf12 + "\r\n" + Cf13;
                        break;
                    case 6:
                        //per ing alimentos
                        string Cg1 = "Demuestra capacidad para el razonamiento verbal, comprensión lectora, técnicas de comunicación y redacción";
                        string Cg2 = "Trabaja en equipo de manera efectiva.";
                        string Cg3 = "Demuestra capacidad para el razonamiento matemático.";
                        string Cg4 = "Aplica los fundamentos generales de las ciencias exactas (algebra, aritmética, geometría y trigonometría). ";

                        //comp ing alimentos
                        string Cg7 = "Investiga en las áreas de ciencia, ingeniería y tecnología de alimentos para dar soluciones científicas e \r\n innovadoras mediante la aplicación de métodos científicos, técnicas e instrumentos adecuado.";
                        string Cg8 = "Analiza los factores que influyen en la transformación de la materia prima y producto terminado, garantizando \r\n un alimento saludable y nutritivo.";
                        string Cg9 = "Desarrolla sistemas de calidad en los productos para que cumplan con los estándares, en base a la normativa vigente \r\n y compromiso con el medio ambiente.";
                        string Cg10 = "Elabora productos para el aprovechamiento integral de materias primas, según los estándares de calidad \r\n alimentaria.";

                        //datos ing alimentos
                        string Cg11 = "GRADO ACADÉMICO: Bachiller en Ingenieria de alimentos";
                        string Cg12 = "TÍTULO PROFESIONAL:Ingeniero de alimentos";
                        string Cg13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Cg1 + "\r\n" + Cg2 + "\r\n" + Cg3 + "\r\n" + Cg4;
                        this.msj2 = Cg7 + "\r\n" + Cg8 + "\r\n" + Cg9 + "\r\n" + Cg10;
                        this.msj3 = Cg11 + "\r\n" + Cg12 + "\r\n" + Cg13;
                        break;
                    case 7:
                        //per ing de minas
                        string Ch1 = "Responsabilidad con el medio ambiente.";
                        string Ch2 = "Habilidades para la creatividad e innovación.";
                        string Ch3 = "Conocimiento básico en inglés y Tecnología Informática.";
                        string Ch4 = "Poseer habilidad y conocimientos en las Ciencias y la Matemática Básica, (matemáticas, físicas y químicas). ";
                        string Ch5 = "Poseer sólidos valores éticos y morales (honestidad, responsabilidad, respeto por la persona), reafirmando \r\n su identidad.";


                        //comp ing de minas
                        string Ch7 = "Formula investigación científica e innovación tecnológica en ingeniería de minas con ética y responsabilidad \r\n social.";
                        string Ch8 = "Controla operaciones mineras, desarrollando actividades amigables con el medio ambiente y cumpliendo con \r\n los estándares y normas vigentes.";
                        string Ch9 = "Ejecuta proyectos mineros, de acuerdo al plan de minado, que aseguren la extracción racional de las \r\n reservas minerales y respeten la normatividad vigente.";


                        //datos ing de minas
                        string Ch11 = "GRADO ACADÉMICO: Bachiller en Ingenieria de Minas";
                        string Ch12 = "TÍTULO PROFESIONAL:Ingeniero de Minas";
                        string Ch13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ch1 + "\r\n" + Ch2 + "\r\n" + Ch3 + "\r\n" + Ch4 + "\r\n" + Ch5;
                        this.msj2 = Ch7 + "\r\n" + Ch8 + "\r\n" + Ch9;
                        this.msj3 = Ch11 + "\r\n" + Ch12 + "\r\n" + Ch13;
                        break;
                    case 8:
                        //per ing sistemas
                        string Ci1 = "Habilidades para la creatividad e innovación";
                        string Ci2 = "Responsabilidad con el medio ambiente.";
                        string Ci3 = "Conocimiento básico en inglés y Tecnología Informática.";
                        string Ci4 = "Poseer sólidos valores éticos y morales (honestidad,responsabilidad, respeto por la persona), \r\n reafirmando su identidad.";
                        string Ci5 = "Poseer habilidad y conocimientos en las Ciencias y la Matemática Básica, (matemáticas, físicas \r\n y químicas).";

                        //comp ing sistemas
                        string Ci7 = "Gestiona proyectos de investigación e innovación tecnológica, de acuerdo a las normas internacionales.";
                        string Ci8 = "Desarrolla aplicaciones empresariales mediante algoritmos que permitan las predicciones según las \r\n normas internacionales y la aplicación de los métodos de investigación.";
                        string Ci9 = "Establece una infraestructura tecnológica, según a las normas Internacionales.";

                        //datos ing sistemas
                        string Ci11 = "GRADO ACADÉMICO: Bachiller en Ingenieria de Sistemas";
                        string Ci12 = "TÍTULO PROFESIONAL:Ingeniero de Sistemas";
                        string Ci13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ci1 + "\r\n" + Ci2 + "\r\n" + Ci3 + "\r\n" + Ci4 + "\r\n" + Ci5;
                        this.msj2 = Ci7 + "\r\n" + Ci8 + "\r\n" + Ci9;
                        this.msj3 = Ci11 + "\r\n" + Ci12 + "\r\n" + Ci13;
                        break;
                    case 9:
                        //per ing electronica
                        string Cj1 = "Los estudiantes amplían sus conocimientos aprendidos durante la sesión de aprendizaje, para proponer \r\n nuevas formas de actuar en el mundo y mejorar la vida de las personas.";
                        string Cj2 = "Tienen habilidad para combinar varias disciplinas, aplicar la teoría en la práctica e integrar varias \r\n áreas, lo cual ayuda a que los estudiantes consigan asociar los conceptos y obtengan una educación integral.";
                        string Cj3 = "El cuidado del medio ambiente, la tolerancia e inclusión social son fundamentales para el estudiante de \r\n esta nueva generación, pues tratan de llevar a cabo acciones en beneficio del planeta, así como respetar las diferentes formas de vivir y el expresarse de cada persona.";
                        string Cj4 = "Conocen otras culturas y personas ya que provienen no sólo de la región Ica, sino también de otras zonas o \r\n departamentos. Hombres y mujeres: Igualdad de oportunidades para acceder a una educación de calidad de acuerdo con el MODELO EDUCATIVO UNIVERSIDAD NACIONAL “SAN LUIS GONZAGA”.";

                        //comp ing electronica
                        string Cj7 = "Diseña sistemas electrónicos de conversión de potencia eléctrica empleando herramientas CAD y CAM, \r\n verificados en base a especificaciones técnicas.";
                        string Cj8 = "Evaluar programas de operación y mantenimiento de equipos y sistemas electrónicos proponiendo soluciones \r\n tecnológicas integrales, según protocolos y estándares internacionales.";
                        string Cj9 = "Implementa soluciones en proyectos de ingeniería de sistemas de comunicaciones y telecomunicaciones \r\n analógicas y digitales verificando su operatividad, según criterios, normas técnicas y legislación vigente.";
                        string Cj10 = "Proyecta el desarrollo de sistemas electrónicos automatizados y de inteligencia artificial para la \r\n industria, comunicación e investigación, empleando herramientas que garanticen el funcionamiento de prototipos, de acuerdo con principios de ingeniería y especificaciones técnicas.";

                        //datos ing electronica
                        string Cj11 = "GRADO ACADÉMICO: Bachiller en Ingenieria Electrónica";
                        string Cj12 = "TÍTULO PROFESIONAL:Ingeniero Electrónico";
                        string Cj13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Cj1 + "\r\n" + Cj2 + "\r\n" + Cj3 + "\r\n" + Cj4;
                        this.msj2 = Cj7 + "\r\n" + Cj8 + "\r\n" + Cj9 + "\r\n" + Cj10;
                        this.msj3 = Cj11 + "\r\n" + Cj12 + "\r\n" + Cj13;
                        break;
                    case 10:
                        //per ing metalurgica
                        string Ck1 = "Practicar la asertividad y empatía.";
                        string Ck2 = "Sensibilidad para apreciar los valores humanos.";
                        string Ck3 = "Conocimiento básico de Tecnología Informática.";
                        string Ck4 = "Permanente observancia de la ética y la moral.";
                        string Ck5 = "Aptitud para la investigación científica y tecnológica";

                        //comp ing metalurgica
                        string Ck7 = "Desarrolla proyectos metalúrgicos, con criterios de calidad, eficiencia, productividad, rentabilidad, \r\n sostenibilidad y responsabilidad social.";
                        string Ck8 = "Desarrolla procesos metalúrgicos de extracción de metales que contribuyan al desarrollo sostenible de \r\n la región, el país y del mundo.";
                        string Ck9 = "Propicia la investigación científica aplicando tecnologías limpias en la industria metalúrgica para la \r\n innovación, según la normativa en la prevención de impactos.";
                        string Ck10 = "Aplica tecnologías para transformar metales y aleaciones en productos acabados, que contribuya al \r\n desarrollo sostenible de la región, del país y del mundo";

                        //datos ing metalurgiaca
                        string Ck11 = "GRADO ACADÉMICO: Bachiller en Ingenieria Metalúrgica";
                        string Ck12 = "TÍTULO PROFESIONAL:Ingeniero Metalúrgico";
                        string Ck13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Ck1 + "\r\n" + Ck2 + "\r\n" + Ck3 + "\r\n" + Ck4 + "\r\n" + Ck5;
                        this.msj2 = Ck7 + "\r\n" + Ck8 + "\r\n" + Ck9 + "\r\n" + Ck10;
                        this.msj3 = Ck11 + "\r\n" + Ck12 + "\r\n" + Ck13;
                        break;
                    case 11:
                        //per ing mecanica electrica
                        string Cl1 = "Los estudiantes amplían sus conocimientos aprendidos durante la sesión de aprendizaje, para proponer \r\n nuevas formas de actuar en el mundo y mejorar la vida de las personas.";
                        string Cl2 = "Tienen habilidad para combinar varias disciplinas, aplicar la teoría en la práctica e integrar varias \r\n áreas, lo cual ayuda a que los estudiantes consigan asociar los conceptos y obtengan una educación integral.";
                        string Cl3 = "El cuidado del medio ambiente, la tolerancia e inclusión social son fundamentales para el estudiante de \r\n esta nueva generación, pues tratan de llevar a cabo acciones en beneficio del planeta así como respetar las diferentes formas de vivir y el expresarse de cada persona.";
                        string Cl4 = "Conocen otras culturas y personas ya que provienen no sólo de la región Ica, sino también de otras zonas \r\n o departamentos. Hombres y mujeres: Igualdad de oportunidades para acceder a una educación de calidad de acuerdo con el MODELO EDUCATIVO UNIVERSIDAD NACIONAL “SAN LUIS GONZAGA”";

                        //comp ing mecanica electrica
                        string Cl7 = "Implementa mecanismos de control de energía en los equipos electromecánicos automatizados, garantizando su \r\n funcionamiento, según normas técnicas y estándares internacionales.";
                        string Cl8 = "Elabora proyectos de estructuras mecánicas, garantizando su operatividad, según principios de ingeniería, \r\n estándares internacionales y normas técnicas vigentes.";
                        string Cl9 = "Planifica proyectos de sistemas electromecánicos de generación, transmisión y distribución de energía \r\n garantizando su factibilidad, de acuerdo con principios de ingeniería y estándares nacionales e internacionales.";
                        string Cl10 = "Desarrollar planes de mantenimiento de equipos electromecánicos e incorpora las mejoras necesarias \r\n garantizando su óptimo funcionamiento, según protocolos y especificaciones técnicas.";

                        //datos ing mecanica electrica
                        string Cl11 = "GRADO ACADÉMICO: Bachiller en Ingenieria Mecácina Eléctrica";
                        string Cl12 = "TÍTULO PROFESIONAL:Ingeniero Mecánico Eléctrico";
                        string Cl13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Cl1 + "\r\n" + Cl2 + "\r\n" + Cl3 + "\r\n" + Cl4;
                        this.msj2 = Cl7 + "\r\n" + Cl8 + "\r\n" + Cl9 + "\r\n" + Cl10;
                        this.msj3 = Cl11 + "\r\n" + Cl12 + "\r\n" + Cl13;
                        break;
                    case 12:
                        //per ing pesquera
                        string Cm1 = "Muestra compromiso ético y respeto por las personas, comunidades y medio ambiente.";
                        string Cm2 = "Conoce de ciencias básicas.";
                        string Cm3 = "Conoce el lenguaje y comunicación.";
                        string Cm4 = "Muestra capacidad de comunicarse y trabajar en equipo. ";
                        string Cm5 = "Posee noción básica de la realidad nacional e internacional de la pesquería.";

                        //comp ing pesquera
                        string Cm7 = "Elabora productos hidrobiológicos garantizando la calidad, según normas vigentes.";
                        string Cm8 = "Formula proceso aprovechamiento integral de los re-hidrobiológicos, disposiciones vigentes.";
                        string Cm9 = "Desarrolla procesos de operación y mantenimiento de embarcaciones pesqueras de acuerdo a la normatividad vigente.";
                        string Cm10 = "Gestiona la investigación científica y tecnológica en transformación, pesca y acuicultura de la \r\n ingeniería Pesquera.";

                        //datos ing pesquera
                        string Cm11 = "GRADO ACADÉMICO: Bachiller en Ciencias pesqueras";
                        string Cm12 = "TÍTULO PROFESIONAL:Ingeniero Pesquero";
                        string Cm13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Cm1 + "\r\n" + Cm2 + "\r\n" + Cm3 + "\r\n" + Cm4 + "\r\n" + Cm5;
                        this.msj2 = Cm7 + "\r\n" + Cm8 + "\r\n" + Cm9 + "\r\n" + Cm10;
                        this.msj3 = Cm11 + "\r\n" + Cm12 + "\r\n" + Cm13;
                        break;
                    case 13:
                        //per ing quimica
                        string Cn1 = "Maneja con regularidad el lenguaje escrito y verbal.";
                        string Cn2 = "Demuestra conocimientos de cultura general.";
                        string Cn3 = "Presenta condiciones para el trabajo en equipo y para el manejo adecuado de relaciones interpersonales";
                        string Cn4 = "Demuestra actitud positiva, respetuosa y responsable.";
                        string Cn5 = "Aplica los fundamentos básicos de matemática, física, química y biología.";
                        string Cn6 = "Conoce las herramientas básicas de la computación e informáticas.";

                        //comp ing quimica
                        string Cn7 = "Desarrolla proyectos de industrialización responsable de los recursos naturales que contribuyan al \r\n desarrollo sostenible de la Región y del País.";
                        string Cn8 = "Desarrolla sistemas de control de la calidad de los productos industriales.";
                        string Cn9 = "Aplica tecnologías modernas en los procesos químicos para la solución de problemas de la industria química.";
                        string Cn10 = "Desarrolla investigación científica y tecnológica en el campo de la ingeniería química para resolver \r\n problemas de la Región.";

                        //datos ing quimica
                        string Cn11 = "GRADO ACADÉMICO: Bachiller en Ingerniería Química";
                        string Cn12 = "TÍTULO PROFESIONAL:Ingeniero Químico";
                        string Cn13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Cn1 + "\r\n" + Cn2 + "\r\n" + Cn3 + "\r\n" + Cn4 + "\r\n" + Cn5 + "\r\n" + Cn6;
                        this.msj2 = Cn7 + "\r\n" + Cn8 + "\r\n" + Cn9 + "\r\n" + Cn10;
                        this.msj3 = Cn11 + "\r\n" + Cn12 + "\r\n" + Cn13;
                        break;
                    case 14:
                        //per matematica e inf
                        string Co1 = "Tener capacidad para el razonamiento lógico y la abstracción.";
                        string Co2 = "Poseer conocimientos elementales de álgebra, geometría, trigonometría, física y estadística.";
                        string Co3 = "Tener habilidad para el manejo de símbolos que representan fenómenos y problemas concretos.";
                        string Co4 = "Poseer valores, como sentido de responsabilidad e interés de superación profesional.";

                        //comp matematica e inf
                        string Co7 = "Comprueba el modelo matemático mediante el uso de algoritmos en la resolución de problemas y la simulación \r\n del problema planteado.";
                        string Co8 = "Construye proposiciones o contraejemplos mediante la aplicación del método científico, la superación de los \r\n problemas resueltos o no resueltos y la difusión de sus resultados.";
                        string Co9 = "Plantea modelos matemáticos mediante el discernimiento de sus ventajas y desventajas en las teorías y técnicas \r\n de la matemática e informática.";
                        string Co10 = "Aplica teorías de las áreas de la matemática e informática, mediante la creación de modelos matemáticos que \r\n describan la realidad.";

                        //datos matematica e inf
                        string Co11 = "GRADO ACADÉMICO: Bachiller en Ciencias Matemática e informática";
                        string Co12 = "TÍTULO PROFESIONAL:Matemático e informático";
                        string Co13 = "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";

                        this.msj = Co1 + "\r\n" + Co2 + "\r\n" + Co3 + "\r\n" + Co4;
                        this.msj2 = Co7 + "\r\n" + Co8 + "\r\n" + Co9 + "\r\n" + Co10;
                        this.msj3 = Co11 + "\r\n" + Co12 + "\r\n" + Co13;
                        break;
                }
            }
        }
    }
}
