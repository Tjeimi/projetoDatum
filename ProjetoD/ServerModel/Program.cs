namespace ServerModel
{
    public static class Program
    {
        //MODELOS DE PACOTES [BANCO DE DADOS]
        public class PessoasModel
        {
            public long? id { get; set; }
            public string? nome { get; set; }
            public long? idong { get; set; }
            public bool? ativo { get; set; }
        }

        public class CategoriasModel
        {
            public long? id { get; set; }
            public string? categoria { get; set; }
            public bool? ativo { get; set; }
        }

        public class ContatoModel
        {
            public long? id { get; set; }
            public long? idpessoa { get; set; }
            public string? tipocontato { get; set; }
            public string? contato { get; set; }
        }

        public class EnderecoModel
        {
            public long? id { get; set; }
            public long? idpessoa { get; set; }
            public string? tipoendereco { get; set; }
            public string? endereco { get; set; }
            public string? bairro { get; set; }
            public string? cidade { get; set; }
            public string? estado { get; set; }
        }
        public class LogModel
        {
            public long? id { get; set; }
            public long? idpessoadoando { get; set; }
            public long? idpessoarecebendo { get; set; }
            public long? idobjeto { get; set; }
            public long? idusuarioresponsavel { get; set; }
            public string? status { get; set; }
        }

        public class ObjetoModel
        {
            public long? id { get; set; }
            public long? idcategoria { get; set; }
            public string? objeto { get; set; }
            public string? imagem { get; set; }
            public string? descricao { get; set; }
        }

        public class ObjetoDoandoModel
        {
            public long? id { get; set; }
            public long? idpessoa { get; set; }
            public long? idcategoria { get; set; }
            public long? idusuario { get; set; }
            public long? idobjeto { get; set; }
        }
        public class ObjetoNecessarioModel
        {
            public long? id { get; set; }
            public long? idpessoa { get; set; }
            public long? idcategoria { get; set; }
            public long? idusuario { get; set; }
        }

        public class ObjetoONGModel
        {
            public long? id { get; set; }
            public bool? ativa { get; set; }
            public string? nome { get; set; }
            public string? endereco { get; set; }
            public string? cidade { get; set; }
            public string? estado { get; set; }
            public string? fone { get; set; }
            public string? email { get; set; }
            public long? idcidadeparceria { get; set; }
        }
        public class ObjetoUsuariosModel
        {
            public long? id { get; set; }
            public long? idong { get; set; }
            public bool? ativo { get; set; }
            public string? nome { get; set; }
            public string? username { get; set; }
            public string? password { get; set; }
            public string? fone { get; set; }
        }

        public class ObjetoEstadosModel
        {
            public long? id { get; set; }
            public string? nome { get; set; }
            public string? sigla { get; set; }
        }
        public class ObjetoCidadesModel
        {
            public long? id { get; set; }
            public long? idestados { get; set; }
            public string? nome { get; set; }
        }

    }
}