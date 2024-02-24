using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorveteria
{
    public  class Item
    {
        public int id { get; set; }

        public int produto_id { get; set; }

        public int pedido_id { get; set; }

        public int quantidade { get; set; }


        // METODO CONSTRUTOR

        public Item(int id, int produto_id, int pedido_id, int quantidade)
        { 
            this.id = id;
            this.produto_id = produto_id;
            this.pedido_id = pedido_id;
            this.quantidade = quantidade;
        }
    }
}
