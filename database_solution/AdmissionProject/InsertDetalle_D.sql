USE Admission
GO

INSERT INTO Detalle(id_area,perfil_estudiante,competencias_profesionales,datos_adicionales) VALUES
(1,
'Tiene conocimientos b�sicos a un nivel medio superior en las �reas de las ciencias naturales.
Es creativo e innovador en el estudio de procesos y t�cnicas biol�gicas.
Tiene habilidades, destrezas y actitudes para la investigaci�n en el campo de las ciencias biol�gicas.
Tiene disponibilidad para el trabajo en equipo mostrando principios y valores �ticos.
Es observador, proactivo y con capacidad de liderazgo para fomentar el cuidado del ambiente, salud p�blica y agroindustria.
Muestra compromiso e identificaci�n con la universidad, sociedad y ambiente.',
'Eval�a sistemas biol�gicos y su entorno, aplicando t�cnicas de an�lisis cl�nicos, biol�gicos, epidemiol�gicos y forenses, en la determinaci�n de metabolitos, identificaci�n celular, de agentes etiol�gicos,\r\n vectores en enfermedades metax�nicas, evidencias biol�gicas en la escena del crimen, de acuerdo con marcos te�ricos, avances cient�ficos, pol�tica nacional de salud y nuevo c�digo \r\n procesal penal, con actitud �tica.
Promueve la conservaci�n del medio ambiente y la biodiversidad seg�n marcos te�ricos actuales que le permite proponer acciones de desarrollo sostenible y bienestar de la comunidad, en el marco de la \r\n normativa nacional e internacional, mostrando una actitud de respeto al ser humano y su entorno.
Gestiona procesos de producci�n acu�cola y agroindustrial, de acuerdo con marcos te�ricos interdisciplinarios que contribuyen al desarrollo del sector y responden a la demanda del mercado nacional e \r\n internacional, seg�n normas de calidad sanitaria e inocuidad, con eficacia, eficiencia, actitud �tica y responsabilidad social.
Gestionar proyectos de investigaci�n, emprendimiento e innovaci�n tecnol�gica en las �reas de salud, conservaci�n, acu�cola y agroindustrial, respondiendo a la demanda del mercado nacional e \r\n internacional, seg�n marcos te�ricos interdisciplinarios y avances cient�ficos, con responsabilidad social.',
'GRADO ACAD�MICO: Bachiller en Ciencias Biol�gicas
T�TULO PROFESIONAL: Bi�logo
DURACI�N DE ESTUDIOS: 5 a�os y 10 semestres
');
GO
SELECT A.id_detalle,D.nombre_area, A.perfil_estudiante,A.competencias_profesionales,A.datos_adicionales
FROM Area A
INNER JOIN
Detalle D ON D.id_area = A.id_area
