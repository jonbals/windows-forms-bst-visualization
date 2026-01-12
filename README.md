# Windows Forms - Drzewo binarne z wizualizacją
Ten projekt to prosta wizualizacja drzewa binarnego (Binary Search Tree) w Windows Forms.

## Jak użyć
Najpierw trzeba pobrać pliki skryptów z repetytorium i wrzucić je do swojego projektu Windows Forms.

<img width="271" height="166" alt="1" src="https://github.com/user-attachments/assets/5e63fd6d-b789-425a-b12a-48612ef3d1c3" />

Następnie w swoim głównym pliku skryptu formularza (Form1.cs) utworzyć nowe zmienne dla drzewa i wizualizacji (BST.Tree i BST.Visualization).
Drzewo można od razu zinicjalizować, natomiast wizualizacje trzeba narazie zostawić bez inicjalizacji. (jak na zdjęciu)

<img width="361" height="206" alt="2" src="https://github.com/user-attachments/assets/19432ea3-ce70-4683-a4a9-d260e5972095" />

W widoku projektanta trzeba stworzyć PictureBox, tu będzie wyświetlała się wizualizacja.

<img width="1142" height="607" alt="4" src="https://github.com/user-attachments/assets/05084957-6ce4-47eb-b114-b7c9a5a8aa27" />

Aby wizualizacja załadowała się poprawnie trzeba wywołać jej konstruktor w Eventcie "Load" głownego formularza

<img width="374" height="423" alt="3" src="https://github.com/user-attachments/assets/384e97c7-b076-4d6f-83b7-32ab8e750889" />

W tej nowo stworzonej funkcji Load należy wywołać konstruktor BST.Visualization (jako parametry podać drzewo i PictureBox który wcześniej stworzyliśmy) 

<img width="576" height="325" alt="5" src="https://github.com/user-attachments/assets/83507b87-cac7-4d17-8579-4b5ad12f0ed6" />

I teoretycznie to tyle! Jeżeli wszystko dobrze poszło to wizualizacja i drzewo powinny już działać.
Tyle że po odpaleniu programu nic się nie wyświetli ponieważ drzewo jest puste.

##

Aby szybko przetestować czy wszystko działa można po prostu w skrypcie dodać coś do drzewa.

Trzeba pamiętać żeby wywołać funkcję Refresh() na naszym PictureBox aby widget się odświeżył i narysował drzewo.

<img width="1196" height="461" alt="6" src="https://github.com/user-attachments/assets/5ab96266-f0c7-4da3-8a7b-a8e9721d0e1d" />

## Przykład użycia

Można w bardzo prosty sposób dodać input dla liczby i przycisk aby można było dodawać wartości do drzewa w trakcie działania programu.

**!! Trzeba pamiętać o wywołaniu funkcji Refresh() na naszym PictureBox za każdym razem kiedy dzieje się jakaś zmiana w drzewie !!**

<img width="1237" height="550" alt="7" src="https://github.com/user-attachments/assets/fdf6209e-990b-463a-b3c3-7450f36b98f8" />





