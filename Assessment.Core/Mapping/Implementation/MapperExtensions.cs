﻿using Assessment.Domain;
using AutoMapper;

namespace Assessment.Core.Mapping.Implementation
{
    public static class MapperExtensions
    {
        internal static IMappingExpression<TSource, TDest> IgnoreAuditColumns<TSource, TDest>(this IMappingExpression<TSource, TDest> expression)
            where TDest : EntityBase, new()
        {
            expression
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Uid, opt => opt.Ignore())
                .ForMember(dest => dest.UpdateDate, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedBy, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore());

            return expression;
        }
    } 
}
