namespace Domain.ServicesImpl.Sys
{
    using System;	
	using Common.BaseDomain;
	using Domain.IRepositorys.Sys;
	using Domain.IServices;
	using Domain.IServices.Sys;
	using Domain.Models.Sys;
    public partial class UserGroupService : BaseService<UserGroup, String>, IUserGroupService
    {
        public UserGroupService(IUserGroupRepository repository) : base(repository)
        {
			// 这是ServiceTemplate代码模板生成（添加方法前，请先对接口IUserGroupService进行修订）
        }
    }
}

