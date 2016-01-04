// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.52
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace LibraryTAL.Data.Designer
{
    // Scores
    public partial class Score
    {
        public Guid ScoreId { get; set; } // ScoreID (Primary key)
        public int Ranking { get; set; } // Ranking
        public Guid? ChampionshipId { get; set; } // ChampionshipID
        public Guid? PointId { get; set; } // PointID
        public Guid? SeasonId { get; set; } // SeasonID

        // Foreign keys
        public virtual Championship Championship { get; set; } // FK__Scores__Champion__22FF2F51
        public virtual Point Point { get; set; } // FK__Scores__PointID__23F3538A
        public virtual Season Season { get; set; } // FK__Scores__SeasonID__24E777C3
        
        public Score()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
