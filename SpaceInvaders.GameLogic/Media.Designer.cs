﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpaceInvaders.GameLogic {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Media {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Media() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SpaceInvaders.GameLogic.Media", typeof(Media).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.IO.UnmanagedMemoryStream semelhante a System.IO.MemoryStream.
        /// </summary>
        public static System.IO.UnmanagedMemoryStream exploshion_short {
            get {
                return ResourceManager.GetStream("exploshion_short", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.IO.UnmanagedMemoryStream semelhante a System.IO.MemoryStream.
        /// </summary>
        public static System.IO.UnmanagedMemoryStream explosion_long {
            get {
                return ResourceManager.GetStream("explosion_long", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap fundo {
            get {
                object obj = ResourceManager.GetObject("fundo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap GameOver {
            get {
                object obj = ResourceManager.GetObject("GameOver", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap inimigo {
            get {
                object obj = ResourceManager.GetObject("inimigo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap jogador {
            get {
                object obj = ResourceManager.GetObject("jogador", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.IO.UnmanagedMemoryStream semelhante a System.IO.MemoryStream.
        /// </summary>
        public static System.IO.UnmanagedMemoryStream Missile {
            get {
                return ResourceManager.GetStream("Missile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap projetil {
            get {
                object obj = ResourceManager.GetObject("projetil", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
