# Lunar-Descent-Module
Land on the moon without running out of fuel

1 Game Concept
Control the Apollo 11 Lunar lander to locate a suitable landing spot, then touch
down gently without running out of fuel.
2 Rules and Mechanics
You have a finite amount of fuel and can thrust as long as fuel is available. Lunar
gravity is a constant downward force on the module. You must find a flat area
large enough to place the module on, using the thruster and gyros. Using the
thruster, you must ensure the craft is not falling too fast when you touch down
(and the craft must be horizontal as well). Acceleration from thrust depends on
both the amount of thrust (which has a maximum value) and the mass of the
craft, including remaining fuel. Score points for the amount of fuel remaining
when you land, winning the game. Lose the game with no points if you crash or
with a small number of points if you achieve escape velocity and leave the moon
(it is not yet determined if the latter is even possible). Exiting the landing region
automatically triggers the abort function, which may result in a crash or escape
depending on velocity and amount of fuel left. High score will be stored.
2.1 Controls
Thrust axis is adjustable from 10% to 60%, or can be set to max with the Abort
button. Attitude is adjustable with respect to two horizontal attitude axes. The
third, vertical axis of rotation, is ignored in this game.
2
2.2 Specifications
The landing module is 10334Kg, including 8200Kg fuel initially, and the fuel has a
specific impulse of 3050 Ns/Kg, giving a total delta-v of 2500 m/s. The maximum
thrust is 45040N. It can be throttled between 10% and 60% max, or set to max
(abort). Thrust is downward relative to the LM, but the attitude (yaw, pitch, and
roll) can be adjusted with gyroscopes. A 1.707 meter long proximity probe on all
but one leg indicates nearness to ground.
3 Asset Requirements
The game requires lunar terrain, a lunar lander module, and a HUD with controls
and readouts, as well as supporting screens like the title screen, game over
screen, instructions screen, an options screen, and a pause screen. Sound and
music are in the game.
3.1 Terrain Assets
The terrain requires a heightmap of the Sea of Tranquility on the Moon, as well as
a moon-rock material. It should be large enough for a reasonable game.
3.2 Landing Module Assets
The landing module has at least two meshes, for the lander and the ascent
modules, and possibly a third for the landing gear. It should also have a realistic
UV-skinned material.
3.3 HUD Assets
The HUD requires a fuel gauge, thrust gauge, proximity indicator, attitude
indicator, and abort indicator.
Helpful but unrealistic would be a height indicator, and indicator that module is
above a suitable landing spot, and velocity gauge. These would be removed in
Advanced mode.
3.4 Audio Assets
Sounds for thrust, land, crash land, gyro movement, warnings for out of fuel and
proximity. Slow, soft, spacy music.
3