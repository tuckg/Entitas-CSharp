﻿using Entitas;
using Entitas.CodeGenerator;
using Entitas.Serialization;

[Pool("PoolB"), Pool("PoolC")]
public class DComponent : IComponent {
    public static ComponentInfo componentInfo { 
        get {
            return new ComponentInfo(
                typeof(DComponent).ToCompilableString(),
                new PublicMemberInfo[0],
                new [] { "PoolB", "PoolC" },
                false,
                "is",
                true,
                true
            );
        }
    }
}

