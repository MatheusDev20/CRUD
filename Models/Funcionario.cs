using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dep { get; set; }
        public string Tel1 { get; set; }
        public string Email { get; set; }
        public string Date { get; set; }
        public string Tel2 { get; set; }
        public Boolean Acess { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string ConfirmSenha { get; set; }
    }
}
