﻿using PerformanceTests.ExecutionAndEntityReaching.Components;
using PerformanceTests.ExecutionAndEntityReaching.SystemCompositionRequirements;
using SimpleECS.Interfaces;

namespace PerformanceTests.ExecutionAndEntityReaching.Systems
{
    public class Sys_A : SysBase
    {
        public Sys_A(IEntityFilterer entityFilterer, IComponentRepository componentRepository)
            : base(entityFilterer, componentRepository, new SysReq_A()){}

        public override void Execute()
        {
            var entities = EntityFilterer.GetCompatibleEntities(ComponentRequirement);
            foreach (var entity in entities)
            {
                var cA = ComponentRepository.GetComponent<CoA>(entity);

                cA.Val++;
            }
        }
    }
}