namespace Core.Entities;

public class Sintomas:BaseEntity
{
    public bool is_VisitaMedico { get; set; }
    public bool is_ConsultaOtroProfesional { get; set; }
    public bool is_VisitaEmergencias { get; set; }
    public bool is_CentroAtencionUrgencias { get; set; }
    public bool is_Hospitalizacion { get; set; }
    public bool is_HospitalizacionProlongada { get; set; }
    public bool is_EnfermedadPeligroVida { get; set; }
    public bool is_Incapacidad { get; set; }
    public bool is_DanoPermantente { get; set; }
    public bool is_PacienteFallecido { get; set; }
    public bool is_AnomaliaCongenita { get; set; }
    public bool is_NaciminetoSinVida { get; set; }
    public bool is_NingunSintoma { get; set; }

    public string sintomasPresentes { get; set; }

    public bool is_AlergiaMedicamentos { get; set; }
    public bool is_AlergiaPolietilenglicol { get; set; }
    public bool is_AlergiaAlimentos { get; set; }
    public bool is_AlergiaMedioAmbiente { get; set; }
    public string alergiasOtras { get; set; }

    public bool is_EnfermedadAddison { get; set; }
    public bool is_EnfermedadAlergias { get; set; }
    public bool is_EnfermedadArritmias { get; set; }
    public bool is_EnfermedadFibrilacionAuricular { get; set; }
    public bool is_EnfermedadVasculitisAutoinmune { get; set; }
    public bool is_EnfermedadParalisisBell { get; set; }
    public bool is_EnfermedadBronquitis { get; set; }
    public bool is_EnfermedadCancer { get; set; }
    public bool is_EnfermedadCeliatica { get; set; }
    public bool is_EnfermedadRenalCronica { get; set; }
    public bool is_EnfermedadInsuficienciaCardiacacCongestiva { get; set; }
    public bool is_EnfermedadCrohn { get; set; }
    public bool is_EnfermedadTVP { get; set; }
    public bool is_EnfermedadDiabetes { get; set; }
    public bool is_EnfermedadEncefalitis { get; set; }
    public bool is_EnfermedadEpilepcia { get; set; }
    public bool is_EnfermedadCorazon { get; set; }
    public bool is_EnfermedadHerpesT1 { get; set; }
    public bool is_EnfermedadHerpesT2 { get; set; }
    public bool is_EnfermedadVIH { get; set; }
    public bool is_EnfermedadHipertension { get; set; }
    public bool is_EnfermedadInflamatorioIntestinal { get; set; }
    public bool is_EnfermedadRenalAguda { get; set; }
    public bool is_EnfermedadHepatica { get; set; }
    public bool is_EnfermedadLupus { get; set; }
    public bool is_EnfermedadAbortoEspontaneo { get; set; }
    public bool is_EnfermedadEsclerosisMultiple { get; set; }
    public bool is_EnfermedadMiasteniaGravis { get; set; }
    public bool is_EnfermedadInfartoMiocardio { get; set; }
    public bool is_EnfermedadMiocarditis { get; set; }
    public bool is_EnfermedadOsteoartritis { get; set; }
    public bool is_EnfermedadPericarditis { get; set; }
    public bool is_EnfermedadAnemiaPerniciosa { get; set; }
    public bool is_EnfermedadNeumonía { get; set; }
    public bool is_EnfermedadPartoPrematuro { get; set; }
    public bool is_EnfermedadPsoriasis { get; set; }
    public bool is_EnfermedadArtritisPsoriásica { get; set; }
    public bool is_EnfermedadpsoriásicaPulmonar { get; set; }
    public bool is_EnfermedadArtritisReumatoide { get; set; }
    public bool is_EnfermedadHerpesZoster { get; set; }
    public bool is_EnfermedadSindromeSjogren { get; set; }
    public bool is_EnfermadadNacimientoSinVida { get; set; }
    public bool is_EnfermedadAccidenteCerebrovascular { get; set; }
    public bool is_EnfermedadAtaquesIsquémicosTransitorios { get; set; }
    public bool is_EnfermedadTrastornoTiroides { get; set; }
    public bool is_EnfermedadColitisUlcerosa { get; set; }
    public string enfermedadOtrasCondiciones { get; set; }

    public ICollection<Paciente>? Pacientes { get; set;}
}
