﻿using Project.DTO.DTOs.Responses;
using Project.DTO.DTOs.RoleDto;

namespace Project.BLL.Abstract;

public interface IRoleService
{
    Task<IDataResult<List<RoleToListDto>>> GetAsync();

    Task<IDataResult<RoleToListDto>> GetAsync(int id);

    Task<IDataResult<Result>> AddAsync(RoleToAddOrUpdateDto dto);

    Task<IDataResult<Result>> UpdateAsync(RoleToAddOrUpdateDto dto);

    Task<IResult> DeleteAsync(int id);
}