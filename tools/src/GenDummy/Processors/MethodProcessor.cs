﻿/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GenDummy.Processors
{
    public class MethodProcessor : IProcessor
    {
        public BlockSyntax DummyBlock { get; set; }

        public MemberDeclarationSyntax Process(MemberDeclarationSyntax member)
        {
            MemberDeclarationSyntax newMember = null;

            if (!(member is MethodDeclarationSyntax method))
            {
                return null;
            }

            if (method.Modifiers.ToString().Contains("override") || method.Modifiers.ToString().Contains("abstract")
                || method.Modifiers.ToString().Contains("private") || method.Modifiers.ToString().Contains("internal")
                || method.Modifiers.ToString().Contains("extern") || method.Parent is InterfaceDeclarationSyntax)
            {
                return null;
            }

            if (method.Body != null)
            {
                newMember = method.WithBody(DummyBlock).WithTrailingTrivia(SyntaxFactory.Whitespace("\r\n"));
            }

            return newMember;
        }
    }
}
