using Dapper;
using DapperExtensions;
using ActiveMidia.Infra.Repository.Dapper.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActiveMidia.Domain.Interfaces.Repository.Local;
using ActiveMidia.Domain.Entities.Local;
using ActiveMidia.Infra.Context.Interfaces;

namespace ActiveMidia.Infra.Repository.Local {
    public class AccountRepository : Repository<AccountEntity>, IAccountRepository {

        public AccountRepository(IDapperContext context)
            : base(context) {
        }        

        public IEnumerable<AccountEntity> GetByDateBetween(DateTime iniDate, DateTime endDate) {

            /*            
            case ExpressionType.Equal:
                return Operator.Eq;
            case ExpressionType.GreaterThan:
                return Operator.Gt;
            case ExpressionType.GreaterThanOrEqual:
                return Operator.Ge;
            case ExpressionType.LessThan:
                return Operator.Lt;
            case ExpressionType.LessThanOrEqual:
                return Operator.Le;
             */

            //Like
            //var predicate = Predicates.Field<AccountEntity>(f => f.Description, Operator.Like, "%" + username + "%");            

            var pga = new PredicateGroup { Operator = GroupOperator.And, Predicates = new List<IPredicate>() };
            pga.Predicates.Add(Predicates.Field<AccountEntity>(f => f.Date, Operator.Ge, iniDate));
            pga.Predicates.Add(Predicates.Field<AccountEntity>(f => f.Date, Operator.Le, endDate));
            
            var obj = Connection.GetList<AccountEntity>(pga);
            
            return obj;
        }

        /*
        public AccountEntity GetByX(string id) {
            var predicate = Predicates.Field<AccountEntity>(f => f.Id, Operator.Eq, id);
            var obj = Connection.GetList<AccountEntity>(predicate).FirstOrDefault();
            return obj;
        }
        

        public void UpdateLastElapsed(int userId, DateTime dataLastElapsed) {
            var command = Connection.CreateCommand();

            string query = @"update tb_instagram_user 
                                set dta_last_elapsed = @DataLastElapsed 
                              where id_instagram_user = @UserId";

            Connection.Execute(query, new { UserId = userId, DataLastElapsed = dataLastElapsed });

        }

        */
    }
}
