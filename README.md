# 🗝️ VR Escape Room  
**Unity Version** | **License** | **Status** | **Platform**  
N/A | MIT License | In Development | VR (Google VR SDK for Unity)  

---

## 📖 Overview  
A thrilling VR Escape Room experience built with Unity using the Google VR SDK! Immerse yourself in a cyberpunk-themed room where you must solve three challenging puzzles to unlock the door and escape. Interact with the environment using gaze-based (reticle) input, designed for a touch-free mobile VR experience. Test your problem-solving skills and escape before time runs out!  

---

## 🕹️ VR ESCAPE ROOM DEMO 

https://github.com/user-attachments/assets/703444dd-a8ef-4b6c-99a0-7fdb2e213f25
---

## ✨ Features  
- 🎮 Gaze-based interaction using Google VR SDK for a seamless VR experience  
- 🔒 Three unique puzzles to solve:  
  - **Puzzle 1**: Gaze at objects in a specific order to unlock  
  - **Puzzle 2**: Enter a number code using a virtual keypad  
  - **Puzzle 3**: Match shapes by dragging and dropping (in progress)  
- 🌃 Cyberpunk-themed environment with immersive models  
- 🖥️ VR-friendly UI canvases (world-space) with:  
  - Hints  
  - Restart button  
  - Timer UI (planned)  
  - Success popup screen (planned)  
- 🔊 Visual and text feedback for puzzle progress and completion  
- 💀 Challenging mechanics to test your VR skills  

---

## 🎮 Controls  
- **Gaze-Based Input**: Look at objects/buttons for 2 seconds to interact (using `GvrReticlePointer`)  
- **Reset Button**: Gaze at the reset button to restart each puzzle  

---

## 🛠️ Technical Details  
Built with Unity, this project features:  
- Gaze-based interaction system using Google VR SDK  
- Scene management for puzzle navigation (`HeadMover`, `SceneSwitcher`)  
- Dynamic UI updates with TextMeshPro for puzzle feedback  
- Parent-child relationships for puzzle objects and UI canvases  
- Coroutines for flashing text animations  
- State management for puzzle completion (`UnlockDoorLogic`)  
- Gyroscope integration for VR head tracking (`GyroScope`)  

---

## 🚀 Getting Started  

### Installation (For Players)  
1. **Download the App**:  
   - Visit the [Releases](https://github.com/<your-username>/<your-repo>/releases) page on GitHub.  
   - Download the latest release package (e.g., `VR_EscapeRoom.zip`).  
2. **Unzip the Package**: Extract the downloaded `.zip` file to a folder on your device.  
3. **Run the App**:  
   - Launch `VR_EscapeRoom.exe` (or the equivalent executable for your platform).  
   - Ensure your VR device is connected and compatible with the Google VR SDK.  

### Installation (For Developers/Contributors)  
1. **Fork the Repository**: Fork this repository to your GitHub account.  
2. **Clone with Git LFS**:  
   - Ensure Git LFS is installed (`git lfs install`).  
   - Clone the repository:  
     ```
     git clone <your-forked-repo-url>
     ```
   - Pull large assets (models) using Git LFS:  
     ```
     git lfs pull
     ```
3. **Open in Unity**:  
   - Open the project in Unity (version N/A as specified).  
   - Ensure the Google VR SDK for Unity is installed in your Unity Editor.  
4. **Run the Game**:  
   - Open the `EscapeRoom` scene in Unity.  
   - Build and run on a compatible VR device, or test in the Unity Editor with VR emulation.  

---

## 🎯 How to Play  
1. Launch the game and navigate to the Escape Room scene from the landing page.  
2. Use gaze-based input to interact with objects:  
   - **Puzzle 1**: Gaze at 5 objects in the correct order (displayed on the UI).  
   - **Puzzle 2**: Gaze at keypad buttons (0-9) to enter a 4-digit code.  
   - **Puzzle 3**: (In progress) Match shapes by gazing at draggable items.  
3. Solve all three puzzles to unlock the door and escape.  
4. Use the reset button to restart a puzzle if needed.  

---

## 💡 Development Notes  

### Architecture  
The game is structured around these key components:  
- **GazeTrigger**: Handles gaze-based interaction for objects and buttons.  
- **PuzzleOneManager**: Manages Puzzle 1 logic (object selection in order).  
- **PuzzleTwoManager**: Manages Puzzle 2 logic (keypad code entry).  
- **UnlockDoorLogic**: Tracks puzzle completion and unlocks the door.  
- **HeadMover**: Positions the player for each puzzle.  
- **SceneSwitcher**: Handles navigation between scenes (e.g., Main Menu, Escape Room).  
- **GyroScope**: Integrates VR head tracking for immersion.  

### Known Issues  
- Gaze interaction may occasionally fail if VR Event System isn’t properly configured.  
- Puzzle 3 is still in development and not fully functional.  

---

## 📝 Future Enhancements  
- Complete Puzzle 3: Shape-matching mechanics with drag-and-drop via gaze.  
- Add a Timer UI to increase challenge.  
- Implement a Success Popup Screen on door unlock.  
- Add more environmental interactions (e.g., dynamic lighting, sound effects).  
- Support for additional VR platforms beyond Google VR SDK.  
- Enhance hints system with more detailed clues.  

---

## 🤝 Contributions  
We welcome contributions to enhance the VR Escape Room! To contribute:  
1. **Fork the Repository**: Fork this repo to your GitHub account.  
2. **Use Git LFS**: Ensure Git LFS is installed and pull large assets (models) as described in the Installation section.  
3. **Make Changes**: Create a new branch for your feature or bugfix (`git checkout -b feature/your-feature-name`).  
4. **Commit and Push**: Commit your changes and push to your fork (`git push origin feature/your-feature-name`).  
5. **Submit a Pull Request**: Open a pull request against the main branch of this repository, describing your changes in detail.  

---

## 📄 License  
This project is licensed under the MIT License - see the LICENSE file for details.  

---

## 👏 Acknowledgments  
- Inspired by classic escape room games and VR interaction concepts.  
- Thanks to the Unity community for resources and support.  
- Models sourced from SketchFab (see Citations/References).  

---

## 📚 Citations/References  
The following models were used in this project, all licensed under Creative Commons Attribution (http://creativecommons.org/licenses/by/4.0/):  
- "Kidman Room" (https://skfb.ly/oRNPN) by Veterock  
- "Futuristic Room" (https://skfb.ly/orWOQ) by denis_cliofas  
- "Conference room - 3D" (https://skfb.ly/ozxz6) by astroboy73  
- "The first game room I made for SketchFab" (https://skfb.ly/6yY6S) by Torey Alvarez 3D Artist and Unity asset production  
- "Moto in cyberpunk style" (https://skfb.ly/oQRvG) by semyon.kan  
- "Cyberpunk Robot" (https://skfb.ly/6RJty) by Josh_NC  
- "Errata Cyberpunk 2077 Katana" (https://skfb.ly/oMHn6) by DJHaski  
- "Cyberpunk Mask" (https://skfb.ly/p8sHA) by nabonilo
