using Dos.ORM;

namespace Apartment.Model.Base
{
    /// <summary>
    /// 扩展Entity Id唯一生成,Dos.Rom 不支持long类型主键
    /// </summary>
    public class EntityExt : Entity
    {
        private string v;

        public EntityExt(string v)
        {
            this.v = v;
        }

        public long Id { get; set; }
    }
}
