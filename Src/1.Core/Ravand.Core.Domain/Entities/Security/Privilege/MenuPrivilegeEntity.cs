using Ravand.Core.Domain.Entities.Setting;

namespace Ravand.Core.Domain.Entities.Security.Privilege;

[Table("MenuPrivileges", Schema = "Security")]
public class MenuPrivilegeEntity : Entity<long>
{
    [ForeignKey(nameof(PrivilegeEntity))]
    public long PrivilegeId { get; private set; }
    public PrivilegeEntity PrivilegeEntity { get; private set; }


    [ForeignKey(nameof(MenuEntity))]
    public long MenuId { get; private set; }
    public MenuEntity MenuEntity { get; private set; }
}
