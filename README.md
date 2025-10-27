# Cel projektu: 
Twoim zadaniem jest stworzenie wieloekranowej aplikacji mobilnej do planowania i śledzenia treningów, bazując na załączonych projektach UI. Aplikacja powinna być w pełni funkcjonalna, z nawigacją między ekranami i dynamiczną obsługą danych. Projekt należy zrealizować w technologii .NET MAUI, stosując wzorzec projektowy MVVM (Model-View-ViewModel). 
Część wizualna (UI / UX) 
## Ekran 1: Wybór trenera (Coach Selection)

- Tło: przyciemnione zdjęcie siłowni z półprzezroczystą warstwą koloru (gradient). 
- Na samej górze: pasek postępu z czterech kropek/cyferek (etapy procesu). 
- Nagłówek: „Choose your AI Coach”. 
- Lista czterech kafelków (każdy w formie karty z zaokrąglonymi rogami): 
- Każdy kafelek zawiera: nazwę trenera, opis, zdjęcie tła. 
- Po kliknięciu – wizualne podświetlenie i przejście do kolejnego kroku. 
 
## Ekran 2: Moje plany (My Workout Plans) 
- Pasek tytułu: „My Workout Plans”. 
- Przycisk z ikoną ➕ do dodawania nowego planu („Build New Plan”). 
- Lista istniejących planów w postaci kafelków: 
- Każdy kafelek ma nazwę planu, nazwę trenera, poziom trudności, typ (np. „Gym and Home”), liczbę treningów i datę utworzenia. 
- Kolorowe etykiety (Label z zaokrągleniem i gradientem) dla poziomu, lokalizacji i liczby treningów. 
- Pasek dolnej nawigacji (ikony planów i profilu). 
- Styl: jasna kolorystyka, pastelowe odcienie fioletu i mięty, białe tło, karty w odcieniach liliowego. 
 
## Ekran 3: Szczegóły planu (Workout Plan) 
- Pasek tytułu: „Workout Plan – [nazwa planu]”. 
- Sekcja: Plan Overview (krótki tekst wprowadzający). 
- Lista treningów w danym planie: 
- Każdy element zawiera: 
    * nazwę treningu, 
    * ilość ćwiczeń, 
    * przewidywany czas trwania, 
    * preferowany dzień tygodnia. 
- Styl: zaokrąglone karty, kolorowe etykiety (Exercise Count, Duration), ikonki aktywności. 
- Styl: tło białe, sekcje oddzielone subtelnymi liniami (BoxView lub Border). 
 
## Ekran 4: Widok treningu (Workout) 
- Pasek tytułu: nazwa treningu, np. „At-Home Circuit”. 
- Główna sekcja: podsumowanie (cel treningu, czas, status czy wykonano). 
- Przycisk akcji: Start Workout (kolor zielony). 
- Lista ćwiczeń (CollectionView): 
  * Każde ćwiczenie: nazwa, liczba serii, powtórzeń, czas, partie ciała, opis sprzętu. 
  * Możliwość dodania rozwijanego opisu („Tap to see guidance”). 
- Styl: Frame dla każdego ćwiczenia z pastelowym akcentem kolorystycznym. 
 
 
## Ekran 5: W trakcie ćwiczeń (Working Out) 
- Na górze: licznik czasu (timer). 
- Nagłówek: „Gym Cardio & Strength”. 
- Dla każdego ćwiczenia: 
  * Nazwa oraz rozwijane szczegóły (Expander z CollectionView w środku), 
  * Wiersze dla poszczególnych serii (Set): wprowadzenie ciężaru (Entry) i liczby powtórzeń (Entry lub Stepper), 
  * Przycisk „+ Add Set”. 
  * Przycisk „Mark As Complete” – zmienia kolor po kliknięciu (np. z szarego na zielony). 
  * Styl: prosty, jasny, z pastelowymi zielonymi i fioletowymi akcentami. 
 
## Część funkcjonalna (logika aplikacji) 
- Aplikacja powinna wykorzystywać MVVM (Model-View-ViewModel) oraz mieć podstawową logikę obsługującą dane: 
- Funkcje niezbędne:
  - Wybór trenera: 
    * po tapnięciu zapisuj wybranego trenera i przejdź do ekranu planów. 
    * Tworzenie planu treningowego: 
      * przycisk „Build New Plan” otwiera nową stronę z formularzem (nazwa planu, poziom, dni tygodnia, typ ćwiczeń). 
      * dodany plan widoczny na liście. 
    * Wyświetlanie listy planów: 
      * dane przechowywane lokalnie. 
    * Powiązanie planu z trenerem: 
      * w strukturze danych WorkoutPlan uwzględnij CoachName, Level, WorkoutList. 
  - Lista treningów wewnątrz planu:
    * kliknięcie w plan przenosi do listy jego treningów. 
    * Timer w trakcie ćwiczeń: 
    * prosty z aktualizacją labela co sekundę. 
    * Oznaczanie wykonanych ćwiczeń: 
    * po kliknięciu w „Mark As Complete” zmienia się kolor i zapisuje stan. 
  - Dodawanie i usuwanie serii: 
  * dynamiczne dodawanie nowych wierszy. 
   
  # Wystarczy stworzyć wszystko na sztywno tak jak jest na zdjęciach. Np.. Wybierając slimseeker przenosi nas na 2 ekran, który dla każdego trenera wygląda tak samo. Każdy plan ma w sobie to samo i przenosi nas na kolejny ekran, który dla każdego planu jest identyczny. 

 

 

 