using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImpressaoZebra
{
    public class Consultas
    {
        public string consultaMinhaLe = "select distinct m.tmer_codigo_barras_ukn as codsap, "+
       "m.tmer_nome as DESCR, "+
       "p.tfid_tipo_preco as tp, "+
       "p.tfid_preco_venda as prc_promo, "+
       "e.tmer_preco_venda as prc_ori, "+
       "p.tfid_data_inicio as inicio, "+
       "p.tfid_data_fim "+
"from tmer_mercadoria m inner join tfid_promocao p on p.tfid_codigo_pri_fk_pk = m.tmer_codigo_pri_pk and "+
                                                     "p.tfid_codigo_sec_fk_pk = m.tmer_codigo_sec_pk "+
                       "inner join tmer_estoque e on e.tmer_unidade_fk_pk = p.tfid_unidade_fk_pk and "+
                                                    "e.tmer_codigo_pri_fk_pk = p.tfid_codigo_pri_fk_pk and "+
                                                    "e.tmer_codigo_sec_fk_pk = p.tfid_codigo_sec_fk_pk "+                         
                                                    "where p.tfid_tipo_preco = 1 "+
                                                    "and p.tfid_preco_venda <> e.tmer_preco_venda "+
                                                    "and p.tfid_data_inicio <= 'now' "+
                                                    "and p.tfid_data_fim >= 'now' ";
    }
}
