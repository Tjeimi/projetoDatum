namespace Models {
    //MODELOS DE PACOTES [BANCO DE DADOS]
    public class PessoasModel {
        public string tablename { get; set; } = "pessoas";
        public long? id { get; set; }
        public string? nome { get; set; }
        public long? idong { get; set; }
        public bool? ativo { get; set; }
        public string? fone { get; set; }
        public string? endereco { get; set; }
        public string? cidade { get; set; }
        public string? estado { get; set; }
    }

    public class ObjetosModel {
        public string tablename { get; set; } = "objetos";
        public long? id { get; set; }
        public long? idpessoa { get; set; }
        public long? idong { get; set; }
        public string? categoria { get; set; }
        public string? objeto { get; set; }
        public byte[]? imagem { get; set; }
        public string? descricao { get; set; }
        public bool? doado { get; set; }
        public bool? doacao { get; set; }
        public bool? necessidade { get; set; }
    }

    public class DadosONGModel {
        public string tablename { get; set; } = "ongs";
        public long? id { get; set; }
        public bool? ativo { get; set; }
        public string? nome { get; set; }
        public string? endereco { get; set; }
        public string? cidade { get; set; }
        public string? estado { get; set; }
        public string? fone { get; set; }
        public string? email { get; set; }

    }

    public class UsuariosModel {
        public string tablename { get; set; } = "usuarios";
        public long? id { get; set; }
        public bool? ativo { get; set; }
        public string? nome { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? fone { get; set; }
    }

    public class BasePacket {
        public string? serverName { get; set; }
        public string? action { get; set; }
        public string? responseTopic { get; set; }
        public object? dados { get; set; }
    }

    public class BasePacketResposta {
        public long? codigo { get; set; }
        public string? mensagem { get; set; }
        public string? dados { get; set; }
    }

    public class ParametersModel {
        public string? pgServerName { get; set; }
        public string? pgPort { get; set; }
        public string? pgUserName { get; set; }
        public string? pgPassword { get; set; }
        public string? pgDatabaseName { get; set; }
    }

}
