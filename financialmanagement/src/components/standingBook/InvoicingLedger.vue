<template>
    <div  v-if="this.$type == '管理员'">
        <el-popover placement="right" width="600" trigger="click" style="margin:0 10px" @hide="add()" v-model="show">
            <div class="inline-block">
                <span class="demonstration">年&nbsp;&nbsp;月：</span>
                <el-date-picker v-model="temdata.ATime" placeholder="选择日期" style="width:180px">
                </el-date-picker>
            </div>
            <div class="inline-block">
                <span class="demonstration">标&nbsp;&nbsp;题：</span>
                <el-input v-model="temdata.ATitle" style="width:180px"></el-input>
            </div>
            <el-button type="success" style="margin-left:20px" circle @click="showoff()">确定</el-button>
            <el-button type="success" icon="el-icon-plus" circle slot="reference">添加</el-button>
        </el-popover>
        <el-table ref="singleTable" :data="tableData" style="width: 100%" > 
            <el-table-column fixed type="index" width="80" label="序号" align="center">
            </el-table-column>
            <el-table-column prop="aTime" label="日期" width="150" align="center">
            </el-table-column>
            <el-table-column prop="aTitle" label="标题" width="150" align="center">
            </el-table-column>
            <el-table-column prop="aType" label="关键词" width="150" align="center">
            </el-table-column>
            <el-table-column prop="aAgree" label="点赞量" width="150" align="center">
            </el-table-column>
            <el-table-column prop="aCollect" label="收藏量" width="150" align="center">
            </el-table-column>
            <el-table-column fixed="right" label="操作">
                <template slot-scope="scope">
                    <el-button style="margin-right: 10px;" @click="edit(scope.row)" type="text" size="small">编辑
                    </el-button>
                    <el-popover placement="top-start" width="500" trigger="click" @hide="update()">
                        <div class="inline-block">
                            <span class="demonstration">年&nbsp;&nbsp;月：</span>
                            <el-date-picker type="month" v-model="temdata.date" placeholder="选择日期" style="width:180px">
                            </el-date-picker>
                        </div>
                        <div class="inline-block">
                            <span class="demonstration">标&nbsp;&nbsp;题：</span>
                            <el-input v-model="temdata.remark" style="width:180px"></el-input>
                        </div>
                        <el-button type="text" slot="reference" @click="changetemp(scope.row.id)">修改</el-button>
                    </el-popover>
                    <el-button style="margin-left: 10px;" @click="del(scope.row.id)" type="text" size="small">删除
                    </el-button>
                </template>
            </el-table-column>
        </el-table>
        <pages :total="total" :currentpage="page" @handleSizeChangeSub="handleSizeChangeFun"
            @handleCurrentChangeSub="handleCurrentChangeFun">
            ></pages>
    </div>
    <notype v-else></notype>
</template>

<script>
import invoicingApi from '@/api/invoicingApi'
import pages from '../utlis/pages.vue';
import notype from '@/components/utlis/notype.vue'

export default {
    components: {
        pages,
        notype
    },
    methods: {
        // 页码点击
        handleSizeChangeFun(v) {
            console.log(v)
        },

        handleCurrentChangeFun(v) { //页面点击
            console.log(v)
            this.page = v; //当前页
            this.GetAllArticle(this.page)
        },
        // 编辑
        edit(row) {
            this.$router.push('/home/invoicingdetail/' + row.id)
        },
        // 删除
        async del(id) {
            this.$confirm('此操作将永久删除该文章，是否继续？', '提示', {
                confirmButtonText: '确定',
                cancelButtonText: '取消',
                type: 'warning'
            }).then(async () => {
                const { data: res } = await invoicingApi.DelSum(id)
                if (res.successed == true) {
                    this.$message({
                        message: '删除成功',
                        type: 'success'
                    })
                    if (this.page != 1 && this.total % 10 == 1) {
                        this.page = this.page - 1
                    }
                    this.GetAllArticle(this.page)
                } else {
                    this.$message({
                        message: '删除失败',
                        type: 'success'
                    })
                }
            }).catch(() => {
                this.$message({
                    message: '已取消删除',
                    type: 'info'
                })
            })
        },
        // 改变缓存数据
        changetemp(id) {
            let c = this.tableData.findIndex(item => item.id == id)
            this.temdata.id = this.tableData[c].id
            this.temdata.date = this.tableData[c].date
            this.temdata.remark = this.tableData[c].remark
        },
        update() {
            this.add()
        },
        setCurrent(row) {
            this.$refs.singleTable.setCurrentRow(row);
        },
        // 添加数据
        async add() {
            if (this.temdata.ATitle != '') {
                const { data: res } = await invoicingApi.AddArticle(this.temdata)
                if (res == 1) {
                    this.$message({
                        type: 'success',
                        message: '添加成功'
                    })
                    this.GetAllArticle(this.page)
                } else if (res == 2) {
                    this.$message({
                        type: 'success',
                        message: '修改成功'
                    })
                    this.GetAllArticle(this.page)
                } else {
                    this.$message({
                        type: 'error',
                        message: '操作失败'
                    })
                }
                this.temdata = {
                    id: 0,
                    date: this.dayjs().$d.getTime(),
                    incoinsum: 0,
                    outcoinsum: 0,
                    surplus: 0,
                    remark: ''
                }
            } else {
                this.$message({
                    type: 'error',
                    message: '请输入标题'
                })
            }
        },
        // 关闭添加弹窗
        showoff() {
            this.show = false
        },
        // 获取所有时间业务总和列表
        async GetAllArticle(page) {
            const { data: res } = await invoicingApi.GetAllArticle(page)
            this.total = res.message * 1
            for (let i = 0; i < res.data.length; i++) {
                this.$set(
                    res.data[i], 'aTime', this.dayjs(res.data[i].aTime).format('YYYY-MM-DD')
                )
            }
            this.tableData = res.data
        }
    },

    data() {
        return {
            page: 1,
            total: 10,
            show: false,
            curid: 0, // 选中id
            // 存储表格
            tableData: [],
            // 临时缓存
            temdata: {
                AId: 0,
                DId: 1,
                AType: '',
                ATitle: '',
                APath: '',
                AContent: '',
                ATime:this.dayjs().$d,
                AAgree:0,
                ACollect:0,
                ALength:0
            }
        }
    },
    created() {
        this.GetAllArticle(this.page)
    }

}
</script>

<style lang="less" scoped>
.inline-block {
    display: inline-block;
    margin-left: 5px;
    height: 40px;
}
</style>