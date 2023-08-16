Requirement:
complete function to check valid ship's position or not.

Details:
- a field 10x10
- 10 ships (1xbattleship-4spot, 2xcruiser-3spot, 3xdestroyer-2spot, 4xsubmarine-1spot) -> 20 spots total
- ships cant be placed next other

Base idea:
- create a position list of spot "1" on field.
- first check number of spot=20.
- identify ship from first item of position list // loop until list clear or got fail check
- position move from left->right, up-> down
=> check rule:
![alt text](https://github.com/QuaChuoi/SovietNavalFieldCheck/blob/master/checkRule.svg)
check 4 position: dont have any X & dont have 2 O at the same time.

Some of test result can be found in TestsRun file.