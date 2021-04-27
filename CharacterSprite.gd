tool
class_name CharacterSprite
extends Sprite

enum Type {
	HITMAN_1,
	HITMAN_2,
	MAN_BLUE,
	MAN_BROWN,
	MAN_OLD,
	MAN_RED,
	ROBOT_1,
	ROBOT_2,
	SOLDIER_1,
	SOLDIER_2,
	SURVIVOR_1,
	SURVIVOR_2,
	WOMAN_GREEN,
	WOMAN_OLD,
	ZOMBIE_1,
	ZOMBIE_2,
	_ENUM_SIZE
}
enum Anim { GUN, HOLD, MACHINE, RELOAD, SILENCER, STAND, _ENUM_SIZE }

export (Anim) var anim: int = Anim.STAND setget set_anim
export (Type) var type: int = Type.HITMAN_1 setget set_type


func _ready() -> void:
	_reload_texture()


func set_anim(value: int):
	anim = value % Anim._ENUM_SIZE
	_reload_texture()


func set_type(value: int):
	type = value % Type._ENUM_SIZE
	_reload_texture()


func _reload_texture():
	texture = load(
		(
			"res://assets/%s/%s_%s.png"
			% [
				get_type_folder(type),
				get_type_name(type),
				get_anim_name(anim),
			]
		)
	)


static func get_anim_name(a: int) -> String:
	match a:
		Anim.GUN:
			return 'gun'
		Anim.HOLD:
			return 'hold'
		Anim.MACHINE:
			return 'machine'
		Anim.RELOAD:
			return 'reload'
		Anim.SILENCER:
			return 'silencer'
		Anim.STAND:
			return 'stand'
		_:
			return ''

static func get_type_name(a: int) -> String:
	match a:
		Type.HITMAN_1:
			return 'hitman1'
		Type.HITMAN_2:
			return 'hitman2'
		Type.MAN_BLUE:
			return 'manBlue'
		Type.MAN_BROWN:
			return 'manBrown'
		Type.MAN_OLD:
			return 'manOld'
		Type.MAN_RED:
			return 'manRed'
		Type.ROBOT_1:
			return 'robot1'
		Type.ROBOT_2:
			return 'robot2'
		Type.SOLDIER_1:
			return 'soldier1'
		Type.SOLDIER_2:
			return 'soldier2'
		Type.SURVIVOR_1:
			return 'survivor1'
		Type.SURVIVOR_2:
			return 'survivor2'
		Type.WOMAN_GREEN:
			return 'womanGreen'
		Type.WOMAN_OLD:
			return 'womanOld'
		Type.ZOMBIE_1:
			return 'zombie1'
		Type.ZOMBIE_2:
			return 'zombie2'
		_:
			return ''

static func get_type_folder(a: int) -> String:
	match a:
		Type.HITMAN_1:
			return 'Hitman 1'
		Type.HITMAN_2:
			return 'Hitman 2'
		Type.MAN_BLUE:
			return 'Man Blue'
		Type.MAN_BROWN:
			return 'Man Brown'
		Type.MAN_OLD:
			return 'Man Old'
		Type.MAN_RED:
			return 'Man Red'
		Type.ROBOT_1:
			return 'Robot 1'
		Type.ROBOT_2:
			return 'Robot 2'
		Type.SOLDIER_1:
			return 'Soldier 1'
		Type.SOLDIER_2:
			return 'Soldier 2'
		Type.SURVIVOR_1:
			return 'Survivor 1'
		Type.SURVIVOR_2:
			return 'Survivor 2'
		Type.WOMAN_GREEN:
			return 'Woman Green'
		Type.WOMAN_OLD:
			return 'Woman Old'
		Type.ZOMBIE_1:
			return 'Zombie 1'
		Type.ZOMBIE_2:
			return 'Zombie 2'
		_:
			return ''
