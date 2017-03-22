using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEF
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("name=DBConn")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        static MovieDBContext()
        {
            //一：数据库不存在时重新创建数据库[默认]
            Database.SetInitializer(new CreateDatabaseIfNotExists<MovieDBContext>());
            //二：每次启动应用程序时创建数据库
            //Database.SetInitializer<testContext>(new DropCreateDatabaseAlways<SpreadtrumPMMContext>());
            //三：策略三：模型更改时重新创建数据库
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CodeFirstDBContext>());
            //策略四：从不创建数据库 
            //Database.SetInitializer<CodeFirstDBContext>(null);
        }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
    }
}
