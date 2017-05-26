namespace ControladorDePedidos.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class senha : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.ItemDaVenda",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Quantidade = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Produto_Codigo = c.Int(),
                        Venda_Codigo = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Produto", t => t.Produto_Codigo)
                .ForeignKey("dbo.Venda", t => t.Venda_Codigo)
                .Index(t => t.Produto_Codigo)
                .Index(t => t.Venda_Codigo);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        DataDeCadastro = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DataDaEfetivacao = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            AddColumn("dbo.Produto", "Fornecedor_Codigo", c => c.Int());
            AddColumn("dbo.Usuario", "Senha", c => c.String());
            CreateIndex("dbo.Produto", "Fornecedor_Codigo");
            AddForeignKey("dbo.Produto", "Fornecedor_Codigo", "dbo.Fornecedor", "Codigo");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemDaVenda", "Venda_Codigo", "dbo.Venda");
            DropForeignKey("dbo.ItemDaVenda", "Produto_Codigo", "dbo.Produto");
            DropForeignKey("dbo.Produto", "Fornecedor_Codigo", "dbo.Fornecedor");
            DropIndex("dbo.ItemDaVenda", new[] { "Venda_Codigo" });
            DropIndex("dbo.ItemDaVenda", new[] { "Produto_Codigo" });
            DropIndex("dbo.Produto", new[] { "Fornecedor_Codigo" });
            DropColumn("dbo.Usuario", "Senha");
            DropColumn("dbo.Produto", "Fornecedor_Codigo");
            DropTable("dbo.Venda");
            DropTable("dbo.ItemDaVenda");
            DropTable("dbo.Fornecedor");
        }
    }
}
