# in-class-activities
## Devlogs
### W1
Metaphor: Shopping in a mall. The whole process is like exploring new things within Unity. When I saw some interesting tools, I would try them just like I walk into stores in the mall. But I still follow the direction as the guideline tells. But eventually, I will find out what I need to add on and run the game successfully. Overall, I think our first minigame project is preparing us for future projects, and I like what we are currently doing.

### W2
1. Variables r, g, and b are floats because they represent the color of the ball. Strings and booleans cannot be used as color variables. Integers can be used, but it will cause the color of the ball to change too quickly.
2. The _bounce is an integer because the amount of ball bouncing cannot be used as a float, string, or bool.
3. Some of the errors are missing a semicolon, and some of them are missing "f" behind the float.

### W3
Table 1: The input will be players who hit the beat, and the output will be the feedback music after hitting. I would like to set the input(player's hit) to be a boolean value, and the initial value is false. It changes to true whenever it gets hit, and the corresponding beat can play as output. After this process, the value of it will always default to false.


MonoBehaviour coding activity: the relationship between classes and components is more likely a show. The classes describe what components can do and how component play their role as being set. Method and member variable can be considered as a food bowl. The member variables are different sides, meat, and rice in the bowl. The method is calling each side and adding them together, and produces a finished bowl.


The ball becomes brighter every time it collides. When it collides, the function will be called and update the color of the ball. And the scene will show the updated color.


### W4
Table 1: The line 5 of the file, a variable is declared and the member variable is 1.0f. It defines an initial value so the program can apply it and update it if it is necessary. The line 22 of the file, variable translation is a float. The line should execute this: when players press "w" or "s", they are entering an input as a vertical direction, so the cat in the scene will move forward/backward as the speed it has been setting. The line 25 of the file, Translate is the method and be called. It also applies a translation variable in the (), which means that the game object will move a certain distance.

The goal should have a IsTrigger because it needs to detect whenever the ball is goaled or not; the soccer ball and cat should have rigidbody. 
My game is not prefect. I try to make the cat not floating in the air, but I could not figure it out still. And I need to fix the rigidbody to make it stands on the ground. 




## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 