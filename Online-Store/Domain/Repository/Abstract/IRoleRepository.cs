﻿using Online_Store.Domain.Entities;

namespace Online_Store.Domain.Repository.Abstract
{
	public interface IRoleRepository
	{
		IQueryable<Role> GetRole();
		Task<Role> GetRoleByIdAsync(Guid id);
		Task<bool> SaveRoleAsync(Role entity);
		Task<bool> DeleteRoleAsync(Guid id);
		Task<bool> SoftDeleteRoleAsync(Role entity);
	}
}
