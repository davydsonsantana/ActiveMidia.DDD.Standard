using ActiveMidia.Domain.Entities;
using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveMidia.Domain.Entities.Local;

namespace ActiveMidia.Infra.Context.Mapeamento {
    public class AccountMapper : ClassMapper<AccountEntity> {
        public AccountMapper() {
            Table("tb_account");

            Map(p => p.Id).Column("id_instagram_user").Key(KeyType.Identity);
            Map(p => p.Description).Column("str_description");
            Map(p => p.Date).Column("dta_date");            

        }
    }
}

