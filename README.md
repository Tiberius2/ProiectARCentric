# ProiectARCentric
A simple AR scene with two tracked images using Vuforia and Unity
There's an apk attached to this project in the APK folder. Simply download and install it 
The tracked images are in the Image Targets folder.
The blend files are present as well

If the two objects get close to each other , close range animation is starting. + UI Text(Event)
Contrarily, if they are far from each other, long range animation is starting + UI Text(Event)

The default is the long range animation for the objects

API Level 26 worked for me, I'm sorry (Android 8.0 Oreo)

!!IMPORTANT!!   If the user touches the screen or presses E on the keyboard(currently commented out) , the robot fires a projectile. If the projectile hits the deathsphere 3 times, the deathsphere is destroyed. Have fun and enjoy !! :)
