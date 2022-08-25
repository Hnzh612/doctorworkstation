<template>
    <div class="friends">
        <el-row v-for="user in users" :key="user.sex">
        <el-menu>
            <el-menu-item>
                <router-link to="/home/messagedetail">
                    <el-col :span="1">
                        <el-image class="pic"  :src="require('@/assets/pic_boy.png')" v-if="user.sex == '男'"></el-image>
                        <el-image  class="pic"  :src="require('@/assets/pic_girl.jpg')" v-else-if="user.sex == '女'"></el-image>
                    </el-col>
                    <el-col :span="1"><div class="name">{{   user.name   }}</div></el-col>
                </router-link>
                
            </el-menu-item>
        </el-menu>
            
        </el-row>
    </div>
</template>

<style>
    .pic{
        width: 50px;
        height: 50px;
    }

    .friends{
        border : 1px;
    }
    .name{
        padding-left: 10px;
        padding-top: 8px;
        font-size: 20px;
    }
</style>

<script>

export default {
    name:'message',
    data(){
        return{
            users:[{
                name: 'a1',
                sex: '男',
                message_no: 23,
                id:1
            },
            {
                name: 'a2',
                sex: '女',
                message_no: 0,
                id:2
            },
            {
                name: 'a3',
                sex: '男',
                message_no: 2,
                id:3
            }],
        }
    }
}
</script>