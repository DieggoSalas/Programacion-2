using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Datos
{
    public class ArticuloDatos
    {
        private List<Articulo> lista = new List<Articulo>();
        private AccesoDatos datos = new AccesoDatos();
        public List<Articulo> listar()
        {
            try
            {
                datos.Consultar("select A.Id, Nombre, A.Descripcion, ImagenUrl, Precio, Codigo, C.Id IdCategoria, C.Descripcion Categoria, M.Id IdMarca, M.Descripcion Marca from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.Id");
                datos.LeerDatos();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if(!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = datos.Lector.GetDecimal(4);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {            
            try
            {
                datos.Consultar("insert into ARTICULOS (Nombre, Descripcion, ImagenUrl, Precio, Codigo, IdCategoria, IdMarca) values (@Nombre, @Descripcion, @ImagenUrl, @Precio, @Codigo, @IdCategoria, @IdMarca)");
                datos.SetearParametros("@Nombre", nuevo.Nombre);
                datos.SetearParametros("@Descripcion", nuevo.Descripcion);
                datos.SetearParametros("@ImagenUrl", nuevo.ImagenUrl);
                datos.SetearParametros("@Precio", nuevo.Precio);
                datos.SetearParametros("@Codigo", nuevo.Codigo);                
                datos.SetearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.SetearParametros("@IdMarca", nuevo.Marca.Id);
                datos.InsertarDatos();
            }
            catch (Exception ex)
            {
                throw ex;                
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
       
        public void modificar(Articulo modificado)
        {
            try
            {
                datos.Consultar("update ARTICULOS set Nombre = @Nombre, Descripcion = @Descripcion, ImagenUrl = @ImagenUrl, Precio = @Precio, Codigo = @Codigo, IdCategoria = @IdCategoria, IdMarca = @IdMarca where Id = @Id");
                datos.SetearParametros("@Nombre", modificado.Nombre);
                datos.SetearParametros("@Descripcion", modificado.Descripcion);
                datos.SetearParametros("@ImagenUrl", modificado.ImagenUrl);
                datos.SetearParametros("@Precio", modificado.Precio);
                datos.SetearParametros("@Codigo", modificado.Codigo);
                datos.SetearParametros("@IdCategoria", modificado.Categoria.Id);
                datos.SetearParametros("@IdMarca", modificado.Marca.Id);
                datos.SetearParametros("@Id", modificado.Id);
                datos.InsertarDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        
        public void eliminar(int id)
        {
            try
            {
                datos.Consultar("delete from ARTICULOS where Id = @Id");
                datos.SetearParametros("@Id", id);
                datos.InsertarDatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public List<Articulo> filtar(string campo, string criterio, string filtro)
        {
            try
            {
                string consulta = "select A.Id, Nombre, A.Descripcion, ImagenUrl, Precio, Codigo, C.Id IdCategoria, C.Descripcion Categoria, M.Id IdMarca, M.Descripcion Marca from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.Id and ";
                switch(campo)
                {
                    case "Nombre":
                        switch(criterio)
                        {
                            case "Comienza con...":
                                consulta += "Nombre like '" + filtro + "%' ";
                                break;
                            case "Termina con...":
                                consulta += "Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a...":
                                consulta += "Precio > " + filtro;
                                break;
                            case "Menor a...":
                                consulta += "Precio < " + filtro;
                                break;
                            default:
                                consulta += "Precio = " + filtro;
                                break;
                        }
                        break;
                    case "Codigo":
                        switch (criterio)
                        {
                            case "Comienza con...":
                                consulta += "Codigo like '" + filtro + "%' ";
                                break;
                            case "Termina con...":
                                consulta += "Codigo like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Codigo like '%" + filtro + "%'";
                                break;
                        }
                        break;
                }

                datos.Consultar(consulta);
                datos.LeerDatos();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = datos.Lector.GetDecimal(4);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
