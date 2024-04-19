using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using DotNetDBF;

public class DatabaseLoader
{

    [Obsolete]
    public DataTable LoadData(string modo)
    {

        DataTable dataTable = new DataTable();
        string pathToDbfFile = null;


        if (modo == "Empleados")
        {
            pathToDbfFile = "R:\\sistemas_carlos\\rrhh\\personal.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);
        }
        else if (modo == "IngresosSinTarjeta")
        {
            pathToDbfFile = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\IngresosEmpleadosSinTarjeta.dbf";

            dataTable = EscanearBaseDeDatos(pathToDbfFile);
        }
        else if (modo == "Horarios")
        {
            pathToDbfFile = "R:\\sistemas_carlos\\rrhh\\novedad.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);

        }
        else if (modo == "TransportesExternosEntrada")
        {
            pathToDbfFile = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\TransportesExternosEntrada.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);

        }
        else if (modo == "TransportesExternosSalida")
        {
            pathToDbfFile = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\TransportesExternosSalida.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);

        }
        else if (modo == "IngresosVisitante")
        {
            pathToDbfFile = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\IngresosVisitante.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);

        }
        else if (modo == "CategoriasEmpleados")
        {
            pathToDbfFile = "R:\\sistemas_carlos\\rrhh\\categoria.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);

        }
        else if (modo == "IngresosEmpleados")
        {
            pathToDbfFile = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\IngresosEmpleados.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);

        }
        else if (modo == "TransportesInternosEntrada")
        {
            pathToDbfFile = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\TransportesInternosEntrada.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);
        }
        else if (modo == "Vehiculos")
        {
            pathToDbfFile = "R:\\sistemas_carlos\\produ\\vehiculos.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);
        }
        else if (modo == "TransportesInternosSalida")
        {
            pathToDbfFile = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\TransportesInternosSalida.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);
        }
        else if (modo == "Choferes")
        {
            pathToDbfFile = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\Choferes.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);
        }
        else if (modo == "Login")
        {
            pathToDbfFile = "R:\\sistemas_nico\\CapturarIngresosVMate\\database\\Login.dbf";
            dataTable = EscanearBaseDeDatos(pathToDbfFile);
        }
        return dataTable;

    }
    public DataTable FiltrarDadosdeBaja(DataTable datatable)
    {
        for (int i = datatable.Rows.Count - 1; i >= 0; i--)
        {
            DataRow fila = datatable.Rows[i];

            // Verificar si la columna que quieres comprobar no es nula
            if (!fila.IsNull("XBAJA"))
            {
                // Si la columna no es nula, eliminar la fila del DataTable original
                datatable.Rows.RemoveAt(i);
            }
        }

        // Devolver el DataTable con las filas eliminadas
        return datatable;
    }

    public DataTable FiltrarChoferes(DataTable dataTable)
    {
        dataTable = LoadData("Empleados");

        DataTable Categorias = LoadData("CategoriasEmpleados");

        DataTable resultados = new DataTable();

        // Define las columnas de resultados
        foreach (DataColumn columna in dataTable.Columns)
        {
            resultados.Columns.Add(columna.ColumnName, columna.DataType);
        }

        foreach (DataRow empleado in dataTable.Rows)
        {
            string legajo = empleado["XLEG"].ToString();

            foreach (DataRow categoria in Categorias.Rows)
            {
                if (legajo == categoria["PLEG"].ToString())
                {
                    if (categoria["PCAT"].ToString() == "CHOFER" || categoria["PCAT"].ToString() == "CHOFER - IVECO")
                    {
                        DataRow nuevaFila = resultados.NewRow();
                        nuevaFila.ItemArray = empleado.ItemArray;
                        resultados.Rows.Add(nuevaFila);
                    }
                }
            }
        }
        foreach (DataColumn columna in resultados.Columns.Cast<DataColumn>().ToArray())
        {
            if (columna.ColumnName != "XLEG" && columna.ColumnName != "XAPE" && columna.ColumnName != "XNOM" && columna.ColumnName != "XDOC")
            {
                resultados.Columns.Remove(columna);
            }
        }

        return resultados;
    }


    [Obsolete]
    private DataTable EscanearBaseDeDatos(string ruta)
    {
        DataTable tablacargada = new DataTable();


        try
        {

            using (var dbfReader = new DBFReader(ruta))
            {
                // Crear columnas en el DataTable basadas en las columnas del archivo DBF
                foreach (var field in dbfReader.Fields)
                {
                    tablacargada.Columns.Add(field.Name, typeof(object));
                }

                // Leer y agregar registros al DataTable
                object[] record;
                while ((record = dbfReader.NextRecord()) != null)
                {
                    // Crear una nueva fila en el DataTable
                    DataRow row = tablacargada.NewRow();

                    // Agregar los valores del registro a la fila del DataTable
                    for (int i = 0; i < record.Length; i++)
                    {
                        row[i] = record[i];
                    }

                    // Agregar la fila al DataTable
                    tablacargada.Rows.Add(row);
                }
            }
        }
        catch (Exception)
        {
        }
        return tablacargada;
    }
}
