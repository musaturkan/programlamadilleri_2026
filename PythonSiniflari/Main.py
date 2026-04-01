from urun import Urun

def main():
    yeniUrun = Urun()

    yeniUrun.id=10
    yeniUrun.ad="Led TV"
    yeniUrun.fiyat=25874
    yeniUrun.eklemeTarihi="2026-05-15"

    yeniUrun.Yaz()


if __name__  == "__main__":
    main()