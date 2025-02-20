using API_Filmes_senai.Context;
using API_Filmes_senai.Domains;
using API_Filmes_senai.Interfaces;

namespace API_Filmes_senai.Repositories
{
    /// <summary>
    /// Classe que vai implementar IGeneroRepository
    /// Ou seja, vamos implementar os metodos, toda a logica dos metodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// Variavel privada e somente leitura
        /// que "guarda" os dados do contexto
        /// </summary>
        private readonly Filmes_Context _context;
        /// <summary>
        /// Construtor do Repositorio
        /// aqui toda vez que o construtor for chamado, os dados do contexto serao disponiveis
        /// </summary>
        /// <param name="context">Dados do contexto</param>
        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;
        }


        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo para cadastrar um novo genero
        /// </summary>
        /// <param name="novoGenero">objeto genero a ser cadastrado</param>
        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //Adiciona um novo genero na tabela Generos(BD)
                _context.Genero.Add(novoGenero);
                
                //Apos o cadastro, salva as alterações(BD)
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> listaGeneros = _context.Genero.ToList();

                return listaGeneros;
            }
            catch (Exception)
            {
                throw;
            }   
        }
    }
}
