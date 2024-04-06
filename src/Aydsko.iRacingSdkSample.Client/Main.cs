using System.Globalization;
using iRacing.IRSDK;

namespace Aydsko.iRacingSdkSample.Client;

public partial class Main : Form
{
    private IRSDKDiskReader? _diskReader;

    public Main()
    {
        InitializeComponent();
    }

    private void Main_Load(object sender, EventArgs e)
    {
    }

    private void MenuItemFileExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void MenuItemHelpAbout_Click(object sender, EventArgs e)
    {
        using var about = new AboutBox();
        _ = about.ShowDialog(this);
    }

    private void MenuItemFileOpen_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog();
#pragma warning disable CA1303 // Do not pass literals as localized parameters
        openFileDialog.Filter = "iRacing Telemetry File|*.ibt";
        openFileDialog.Title = "Open iRacing Telemetry File";
        openFileDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "iRacing", "telemetry");
#pragma warning restore CA1303 // Do not pass literals as localized parameters

        Cursor.Current = Cursors.WaitCursor;
        Enabled = false;
        try
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _diskReader = new IRSDKDiskReader(openFileDialog.FileName);
                Text = $"{Path.GetFileName(openFileDialog.FileName)} - iRacing SDK Sample";
                textSessionStringDisplay.Text = _diskReader.getSessionStr()?.Replace("\n", Environment.NewLine, StringComparison.OrdinalIgnoreCase);

                // Add columns first, as this must be done before adding rows.
                for (var columnIndex = 0; columnIndex < _diskReader.getNumVars(); columnIndex++)
                {
                    gridViewTelemetryVariables.Columns.Add(columnIndex.ToString(CultureInfo.InvariantCulture), _diskReader.getVarName(columnIndex));
                }

                for (var recordIndex = 0; recordIndex < _diskReader.getNumRecords(); recordIndex++)
                {
                    _diskReader.readNextRecordLine();
                    gridViewTelemetryVariables.Rows.Add();

                    for (var columnIndex = 0; columnIndex < _diskReader.getNumVars(); columnIndex++)
                    {
                        gridViewTelemetryVariables.Rows[recordIndex].Cells[columnIndex].Value = Convert.ToString(_diskReader.getVarValue(columnIndex), CultureInfo.CurrentCulture);
                    }
                }
            }
        }
        finally
        {
            Cursor.Current = Cursors.Default;
            Enabled = true;
        }

    }

    private void Main_FormClosed(object sender, FormClosedEventArgs e)
    {
#pragma warning disable CA1303 // Do not pass literals as localized parameters
        Text = "iRacing SDK Sample";
#pragma warning restore CA1303 // Do not pass literals as localized parameters
        textSessionStringDisplay.ResetText();
        _diskReader?.closeFile();
        _diskReader = null;
    }
}
