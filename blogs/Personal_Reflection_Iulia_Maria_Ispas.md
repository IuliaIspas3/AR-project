Personal Reflection – Iulia Maria Ispas


Main Contributions:
- Focused on UI systems for both the AR and VR projects, including Canvas setup, layout, and text population.
- Contributed to integrating 3D models with UI elements in AR, enabling interactive planet selection and display.
- Contributed to environment setup, object interactions, and testing in both AR and VR projects.
- Contributed in implementing scoring logic and feedback systems for the VR project.
- Tested builds on devices (mobile for AR, Meta Quest for VR) to verify interactions and performance.



Throughout these projects, I gained experience in all aspects of XR development, from building interactive worlds to handling user input, while focusing primarily on UI implementation. Working as a team meant that although my main contributions were UI-related, I also participated in designing the environments, adding object interactions, and testing the systems on the target platforms.

One of the most important theoretical areas that became clear through practice was tracking. In the AR project, we relied heavily on plane detection and screen-based raycasting to allow users to interact with planets placed in the real world. The reliability of tracking directly influenced how we designed interactions: small inaccuracies could lead to missed inputs or unintended selections. Understanding the AR session structure, XR origin, and AR camera setup helped me appreciate the connection between the theory and practical implementation. For instance, placing the UI planets as children of the AR camera allowed us to combine 3D objects with UI elements while keeping them stable from the user’s perspective, which would have been harder without understanding the rendering modes and camera hierarchy.

In both projects, raycasting was essential for detecting user input. In AR, we cast rays from the touch position on the screen to the AR scene; in VR, we cast rays from controller positions to detect interactions with objects like trash items and bins. Learning to implement these interactions in Unity reinforced the importance of input management and the role of scripts in connecting theoretical systems like managers and trackables with practical user actions.

In the VR project, the core template allowed us to quickly set up an environment and test object interactions. Even though we were able to implement grabbing and throwing mechanics successfully, I became aware that the interaction experience could be further improved. For example, currently the trash objects need a more precise alignment to go into the bins, and players can miss occasionally. Improvements could include for example adding guided snapping zones, or implementing subtle attraction forces toward bins to make the gameplay feel smoother and more responsive. These adjustments would rely on both physics understanding and careful controller interaction design, tying practical experience back to XR theory.

UI design in both projects also required combining theory and implementation. In AR, we worked with Screen Space – Overlay canvases to ensure 2D UI elements (like planet information panels) remained consistently visible, while combining them with 3D objects. In VR, we used World Space canvases for the scoreboard and feedback, respecting immersion and spatial placement. Both approaches highlighted trade-offs between usability, immersion, and responsiveness, reinforcing the need to carefully choose rendering modes based on the interaction scenario.

A large part of my learning came from debugging and problem-solving. In AR, implementing the 3D UI planets involved several challenges: managing multiple active objects, ensuring only one was visible at a time, and aligning them correctly with the camera. In VR, testing trash object interactions revealed issues with collisions and scoring logic. Troubleshooting these problems required careful inspection of colliders, raycast hits, and script execution order. Each bug we encountered became an opportunity to better understand how Unity’s XR components, physics, and input systems work together. This iterative problem-solving process gave me a deeper appreciation for the technical complexity behind seemingly simple interactions.

From a broader perspective, these projects strengthened my understanding of how XR combines creativity and technical precision. Concepts like AR sessions, camera hierarchies, raycasting, and rendering modes are not just theoretical, they directly affect usability and interaction quality. Testing on real devices emphasized the importance of balancing performance, responsiveness, and immersion. Overall, I feel confident in taking ownership of both design and technical decisions while remaining aware of areas for improvement.

In conclusion, these projects allowed me to gain hands-on experience across all aspects of XR development, from UI and environment design to interaction implementation and testing. They helped me connect course theory with practical applications, reinforced the importance of debugging and problem-solving, and highlighted the subtle design choices that make AR and VR experiences both functional and engaging. I now feel better prepared to approach XR projects holistically, understanding both the user experience and the technical foundation required to create it.


