using System;

public class Developer
{
	private string nama_dev;
	private string id_dev;
	private string id_proyek;
	private string status_kontrak;
	private int fitur_selesai;
	private int jumlah_bug;
	public string Nama_dev {
		get { return nama_dev; }
			}
    public string Id_dev
    {
        get { return id_dev; }
    }
    public string Id_proyek
    {
        get { return id_proyek; }
    }
    public string Status_kontrak
    {
        get { return status_kontrak; }
    }
    public int Fitur_selesai
    {
        get { return fitur_selesai; }
    }
    public int Jumlah_bug
    {
        get { return jumlah_bug; }
    }
    public Developer()
	{
	}
}
