debugger
import * as THREE from 'three'

import { GLTFLoader } from 'three/examples/jsm/loaders/GLTFLoader.js';

import { FBXLoader } from 'three/examples/jsm/loaders/FBXLoader.js';

import { RGBELoader } from 'three/examples/jsm/loaders/RGBELoader';

// import { DRACOLoader } from 'three/examples/jsm/loaders/DRACOLoader'

import { OrbitControls } from 'three/examples/jsm/controls/OrbitControls';

import  Dat  from 'three/examples/jsm/libs/dat.gui.module.js';

import  Stats  from 'three/examples/jsm/libs/stats.module.js';


// �ҫ� Loader
THREE.GLTFLoader = GLTFLoader;

THREE.FBXLoader = FBXLoader;

// THREE.DRACOLoader = DRACOLoader

// HDR Loader
THREE.RGBELoader = RGBELoader;

// ���
THREE.OrbitControls = OrbitControls;

// ���A���O
THREE.Dat = Dat;
THREE.Stats = Stats;

// ���ҫ��۰ʰϤ�
THREE.ModelAutoCenter =function(group){
		/**
		 * �]�򲰥��۰ʭp��G�ҫ�����Ϥ�
		 */
		var box3 = new THREE.Box3()
		// �p��h�żҫ�group���]��
		// �ҫ�group�O�[���@�ӤT���ҫ���^����H�A�]�t�h�Ӻ���ҫ�
		box3.expandByObject(group)
		// �p��@�Ӽh�żҫ������]�򲰪��X���餤�ߦb�@�ɮy�Ф�����m
		var center = new THREE.Vector3()
		box3.getCenter(center)
		// console.log('�d�ݴX���餤�߮y��', center);

		// ���s�]�m�ҫ�����m�A�Ϥ��~���C
		group.position.x = group.position.x - center.x
		group.position.y = group.position.y - center.y
		group.position.z = group.position.z - center.z
}

export default THREE;