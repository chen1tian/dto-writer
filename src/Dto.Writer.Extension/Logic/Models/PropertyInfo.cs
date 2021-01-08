using Dto.Writer.Logic.PropertyMappers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace Dto.Writer.Logic.Models
{
    public class PropertyInfo
    {
        public string Name { get; set; }

        public TypeSyntax Type { get; set; }

        public string TypeName { get; set; }

        public bool HasSetter { get; set; }

        public bool IsEnumerableType { get; set; }

        public bool IsGenericType { get; set; }

        public bool IsEnabled { get; set; } = true;

        public PropertyMapper Mapper { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public IEnumerable<SyntaxTrivia> CommentTrivias { get; set; }
    }
}
