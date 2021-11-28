var AssessmentEngine = window.AssessmentEngine || {};

AssessmentEngine.Mixins = AssessmentEngine.Mixins || {};

AssessmentEngine.Mixins.grid = {
    data: function() {
        return {
            sortKey: '',
            pageSize: 10,
            sortOrders: {},
            pageable: new AssessmentEngine.Pageable([], this.pageSize),
            currentPage: 0,
            shiftCount: 0
        }
    },
    watch: {
        pageSize: function(val) {
            this.pageable.pageSize = parseInt(val, 10);
        }
    },
    computed: {
        sortedPageable: function() {
            this.pageable.collection = this.sortGridData(this.pageable.collection, this.sortKey, this.sortOrders);

            return this.pageable.getPage(this.currentPage);
        },
        pages: function() {
            return this.pageable.getDisplayPages(this.shiftCount);
        },
        currentMaxPage: function() {
            return this.pages.slice(-1)[0];
        },
        showPreviousPage: function() {
            return this.currentMaxPage > this.pageable.maxDisplayPages
        },
        showNextPage: function() {
            return this.currentMaxPage < this.pageable.getPages().length
        }
    },
    methods: {
        setPage: function(page) {
            this.currentPage = page - 1;
        },
        shiftPagesLeft: function() {
            if (this.shiftCount > 0) {
                this.shiftCount -= 1;
            }
        },
        shiftPagesRight: function() {
            if (this.currentMaxPage < this.pageable.collection.length) {
                this.shiftCount += 1;
            }
        },
        sortBy: function(key) {
            this.sortKey = key;
            this.sortOrders[key] = this.sortOrders[key] * -1;
        },
        buildSortMetadata: function(gridData) {
            const sortOrders = {};
            let columns = [];

            if (gridData && gridData[0]) {
                columns = Object.keys(gridData[0])
            }

            columns.forEach(key => {
                sortOrders[key] = 1;
            });

            return {
                sortOrders: sortOrders,
                columns: columns
            };
        },
        sortGridData: function(gridData, sortKey, sortOrders) {
            let order = sortOrders[sortKey] || 1;
            let sortedGridData = gridData;

            if (sortKey) {
                sortedGridData = AssessmentEngine.Utility.sortArray(gridData, sortKey, order);
            }

            return sortedGridData;
        }
    }
}